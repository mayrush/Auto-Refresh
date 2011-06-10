@echo off 
if exist "PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" "PageRefresher.dll"
if exist "bin\Debug\PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" "bin\Debug\PageRefresher.dll"
if exist "bin\Release\PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" "bin\Release\PageRefresher.dll"

pause