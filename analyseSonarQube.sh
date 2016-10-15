#!/bin/sh
# Beenden bei Fehler
set -e

if [ "$TRAVIS_PULL_REQUEST" = "false" ]; then
    echo "SonarQube-Anylyse..."
    mvn clean org.jacoco:jacoco-maven-plugin:prepare-agent package sonar:sonar -B -e -V -Dsonar.host.url=$SONAR_HOST_URL -Dsonar.login=$SONAR_TOKEN
elif [ "$TRAVIS_PULL_REQUEST" != "false" ]; then
    echo "Pull-Request - SonarQube-Analyse..."
    mvn clean package sonar:sonar -B -e -V \
		-Dsonar.host.url=$SONAR_HOST_URL \
		-Dsonar.login=$SONAR_TOKEN \
		-Dsonar.analysis.mode=preview \
		-Dsonar.github.oauth=$GITHUB_TOKEN \
		-Dsonar.github.repository=$TRAVIS_REPO_SLUG \
        -Dsonar.github.pullRequest=$TRAVIS_PULL_REQUEST
fi