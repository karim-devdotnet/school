$zipFile = "miktexsetup.zip";
if(Test-Path $zipFile)
{
    rm "$zipFile";
}

$exeFile = "miktexsetup.zip";
if(Test-Path $exeFile)
{
    rm "$exeFile";
}

. wget http://mirror.ctan.org/systems/win32/miktex/setup/miktexsetup.zip -OutFile "$zipFile";

Expand-Archive -Path "$zipFile" -DestinationPath "." -Force;

& '.\miktexsetup.exe'