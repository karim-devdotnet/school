#!/bin/sh
# Beenden bei Fehler
set -e

echo "Start SonarQube-Analyse..."
mvn clean org.jacoco:jacoco-maven-plugin:prepare-agent package sonar:sonar -B -e -V -Dsonar.host.url=$SONAR_HOST_URL -Dsonar.login=$SONAR_TOKEN -Dsonar.branch=$TRAVIS_BRANCH
echo "Ende SonarQube-Analyse..."