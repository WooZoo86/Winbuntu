# File references

# Global Variables              
$start_time = Get-Date            
$prog_loc = (Resolve-Path .\).Path
$userenv = [System.Environment]::GetEnvironmentVariable("Path", "User")

# A simple method to allow us to reboot the computer in the middle of the script
workflow Persistent_Reboot { Restart-Computer -Wait }

# Enables WSL as a feature
Enable-WindowsOptionalFeature -Online -FeatureName Microsoft-Windows-Subsystem-Linux
Persistent_Reboot

# Downloads the ubuntu client
Invoke-WebRequest -Uri https://aka.ms/wsl-ubuntu-1604 -OutFile Ubuntu.appx -UseBasicParsing
Rename-Item ~/Ubuntu.appx ~/Ubuntu.zip
Expand-Archive ~/Ubuntu.zip ~/Ubuntu

# Adds the ubuntu application to your path
[System.Environment]::SetEnvironmentVariable("PATH", $userenv + "C:\Users\Administrator\Ubuntu", "User")

# Finally, restarts the computer so changes take effect
Write-Output "Time taken: $((Get-Date).Subtract($start_time).Seconds) second(s)"
Write-Host "Restarting computer to save changes"
Restart-Computer    