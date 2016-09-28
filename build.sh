#!/usr/bin/env bash

#exit if any command fails
set -e

sh ./src/WebApi/build.sh

sh ./src/WebClient/build.sh