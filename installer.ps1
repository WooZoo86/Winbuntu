# You must run the script as admin
#Requires -RunAsAdministrator

# Global Variables              
$start_time = Get-Date            
$prog_loc = (Resolve-Path .\).Path
# This variable is where Winbuntu is going to install, change this if you want to change the install location
$install_loc = "C:\Program Files (x86)\Winbuntu"
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")

$WSL = (Get-WindowsOptionalFeature -Online | Where-Object FeatureName -eq Microsoft-Windows-Subsystem-Linux)
if ($WSL.State -eq "Disabled") {
    Write-Host "Please install Windows Subsystem for Linux"
    exit
}

# Removes bloat, Script created by Sycnex @ https://github.com/Sycnex/Windows10Debloater
$debloat_url = "https://raw.githubusercontent.com/Sycnex/Windows10Debloater/master/Windows10Debloater.ps1"
$debloat_file = "$install_loc\debloat.ps1"
Invoke-WebRequest -Uri $debloat_url -OutFile $debloat_file -UseBasicParsing
Invoke-Item -Path $debloat_file

# Creating the home directory for Winbuntu
if (Test-Path $install_loc) {
    Write-Host "Installation location already exists, please remove '$install_loc' and restart the installer."
    exit
} else { Invoke-Expression "mkdir '$install_loc'" }

# Downloads the ubuntu client
Write-Host "Downloading and extracting Ubuntu terminal"
$ubuntu = "$install_loc\Ubuntu.appx"
Invoke-WebRequest -Uri https://aka.ms/wsl-ubuntu-1604 -OutFile $ubuntu -UseBasicParsing
Rename-Item $install_loc\Ubuntu.appx $install_loc\Ubuntu.zip
Expand-Archive $install_loc\Ubuntu.zip $install_loc\Ubuntu

# Adds the ubuntu application to your path
Write-Host "Adding Ubuntu to path"
[System.Environment]::SetEnvironmentVariable("PATH", $userenv + $install_loc, "User")

# Finally, restarts the computer so changes take effect
Write-Host "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"
Write-Host "Restarting computer to save changes"
#Restart-Computer   
