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

dotnet --verbose restore $PSScriptRoot/src/$webApiNameString;
dotnet --verbose build $PSScriptRoot/src/$webApiNameString -c Release;
dotnet --verbose pack $PSScriptRoot/src/$webApiNameString -o $buildOutputDirectoryPath/$webApiNameString/;

dotnet --verbose restore $PSScriptRoot/src/$webClientNameString;
dotnet --verbose build $PSScriptRoot/src/$webClientNameString -c Release;
dotnet --verbose pack $PSScriptRoot/src/$webClientNameString -o $buildOutputDirectoryPath/$webClientNameString/;