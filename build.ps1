# Build-Skript für Windows mit PowerShell

$buildOutputDirectoryName = "buildOutput";

$buildOutputDirectoryPath = $PSScriptRoot + "\" + $buildOutputDirectoryName + "\";

Write-Host -ForegroundColor Yellow "Build-Directory-Output-Path: "$buildOutputDirectoryPath;

# Wenn nicht vvorhanden, dann erstellen
if((Test-Path -Path $buildOutputDirectoryPath) -eq $false)
{
    New-Item $buildOutputDirectoryPath -ItemType "directory" | Out-Null;
    if((Test-Path -Path $buildOutputDirectoryPath) -eq $true)
    {
        Write-Host -ForegroundColor Green "Build-Ordner erfolgreich erstellt";
    }
    else {
        Write-Host -ForegroundColor Red "Build-Ordner erstellen fehlgeschlagen";
        exit;
    }
}
else {
    # Alle Dateien und Ordner löschen
    Get-ChildItem -Path $buildOutputDirectoryPath -Include *.* -Recurse | foreach { $_.Delete() };
    Get-ChildItem -Path $buildOutputDirectoryPath | foreach { [io.directory]::Delete($_.FullName) };
}

$webApiNameString = "WebApi";
$webClientNameString = "WebClient";

Write-Host -ForegroundColor Yellow "Start restore WebApi.Model";
dotnet --verbose restore $PSScriptRoot/src/$webApiNameString.Model;
Write-Host -ForegroundColor Yellow "Ende restore WebApi.Model";

Write-Host -ForegroundColor Yellow "Start build WebApi.Model";
dotnet --verbose build $PSScriptRoot/src/$webApiNameString.Model -c Release;
Write-Host -ForegroundColor Yellow "Ende build WebApi.Model";

Write-Host -ForegroundColor Yellow "Start restore WebApi";
dotnet --verbose restore $PSScriptRoot/src/$webApiNameString;
Write-Host -ForegroundColor Yellow "Ende restore WebApi";

Write-Host -ForegroundColor Yellow "Start build WebApi";
dotnet --verbose build $PSScriptRoot/src/$webApiNameString -c Release;
Write-Host -ForegroundColor Yellow "Ende build WebApi";

Write-Host -ForegroundColor Yellow "Start restore WebApi.Test";
dotnet --verbose restore $PSScriptRoot/src/$webApiNameString.Test;
Write-Host -ForegroundColor Yellow "Ende restore WebApi.Test";

Write-Host -ForegroundColor Yellow "Start build WebApi.Test";
dotnet --verbose build $PSScriptRoot/src/$webApiNameString.Test;
Write-Host -ForegroundColor Yellow "Ende build WebApi.Test";

Write-Host -ForegroundColor Yellow "Start test WebApi.Test";
dotnet --verbose test $PSScriptRoot/src/$webApiNameString.Test;
Write-Host -ForegroundColor Yellow "Ende test WebApi.Test";

Write-Host -ForegroundColor Yellow "Start restore WebClient";
dotnet --verbose restore $PSScriptRoot/src/$webClientNameString;
Write-Host -ForegroundColor Yellow "Ende restore WebClient";

Write-Host -ForegroundColor Yellow "Start restore WebClient";
dotnet --verbose build $PSScriptRoot/src/$webClientNameString -c Release;
Write-Host -ForegroundColor Yellow "Ende restore WebClient";