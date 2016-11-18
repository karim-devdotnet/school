#!/usr/bin/env bash

#exit if any command fails
set -e

artifactsFolder="./artifacts"

if [ -d $artifactsFolder ]; then
  rm -R $artifactsFolder
fi

sh ./src/WebApi/build.sh

sh ./src/WebClient/build.sh

chmod ugo=rx ./dockerfiles/webapi/linux/docker_build.sh 

sh ./dockerfiles/webapi/linux/docker_build.sh