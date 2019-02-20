# You must run the script as admin
#Requires -RunAsAdministrator

# Global Variables              
$start_time = Get-Date            
$prog_loc = (Resolve-Path .\).Path
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")

$WSL = (Get-WindowsOptionalFeature -Online | where FeatureName -eq Microsoft-Windows-Subsystem-Linux)
if ($WSL.State -eq "Disabled") {
    Write-Host "Please install Windows Subsystem for Linux"
    exit
}


# Downloads the ubuntu client
Write-Host "Downloading and extracting Ubuntu terminal"
Invoke-WebRequest -Uri https://aka.ms/wsl-ubuntu-1604 -OutFile Ubuntu.appx -UseBasicParsing
Rename-Item ~/Ubuntu.appx ~/Ubuntu.zip
Expand-Archive ~/Ubuntu.zip ~/Ubuntu

# Adds the ubuntu application to your path
Write-Host "Adding Ubuntu to path"
InlineScript { [System.Environment]::SetEnvironmentVariable("PATH", $userenv + "C:\Users\Administrator\Ubuntu", "User") }

# Finally, restarts the computer so changes take effect
Write-Host "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"
#Write-Host "Restarting computer to save changes"
#Restart-Computer   
