#!/usr/bin/env bash

#exit if any command fails
set -e

dotnet restore ./src/WebApi.Model

dotnet build ./src/WebApi.Model -c Release -f net460

dotnet restore ./src/WebApi

# Ideally we would use the 'dotnet test' command to test netcoreapp and net451 so restrict for now 
# but this currently doesn't work due to https://github.com/dotnet/cli/issues/3073 so restrict to netcoreapp

dotnet restore ./src/WebApi.Test -f net460

dotnet build ./src/WebApi.Test -c Release -f net460

dotnet test ./src/WebApi.Test -c Release -f net460

# Instead, run directly with mono for the full .net version 
dotnet build ./src/WebApi -c Release -f net460

#mono \  
#./test/TEST_PROJECT_NAME/bin/Release/net451/*/dotnet-test-xunit.exe \
#./test/TEST_PROJECT_NAME/bin/Release/net451/*/TEST_PROJECT_NAME.dll

revision=${TRAVIS_JOB_ID:=1}  
revision=$(printf "%04d" $revision) 

dotnet pack ./src/WebApi -c Release -o ./artifacts --version-suffix=$revision