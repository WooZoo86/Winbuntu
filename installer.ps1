# You must run the script as admin
#Requires -RunAsAdministrator

# Global Variables              
$start_time = Get-Date            
$prog_loc = (Resolve-Path .\).Path
$install_loc = "C:\Program Files (x86)\Winbuntu"
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")

$WSL = (Get-WindowsOptionalFeature -Online | Where-Object FeatureName -eq Microsoft-Windows-Subsystem-Linux)
if ($WSL.State -eq "Disabled") {
    Write-Host "Please install Windows Subsystem for Linux"
    exit
}

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
$addPath = [System.Environment]::SetEnvironmentVariable("PATH", $userenv + $install_loc, "User")
Invoke-Expression $addPath

# Finally, restarts the computer so changes take effect
Write-Host "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"
Write-Host "Restarting computer to save changes"
#Restart-Computer   
