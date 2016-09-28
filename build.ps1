# Build-Skript für Windows mit PowerShell

$buildOutputDirectoryName = "buildOutput";

$buildOutputDirectoryPath = $PSScriptRoot + "\" + $buildOutputDirectoryName + "\";

Write-Host "Build-Directory-Output-Path: "$buildOutputDirectoryPath;

$webApiNameString = "WebApi";
$webClientNameString = "WebClient";

dotnet --verbose restore $PSScriptRoot/src/$webApiNameString;
dotnet --verbose build $PSScriptRoot/src/$webApiNameString;

dotnet --verbose restore $PSScriptRoot/src/$webClientNameString;
dotnet --verbose build $PSScriptRoot/src/$webClientNameString;