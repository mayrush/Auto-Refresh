@echo off 
if exist "IEPageRefresherForRegressionResult\PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" /unregister "IEPageRefresherForRegressionResult\PageRefresher.dll"
if exist "IEPageRefresherForRegressionResult\bin\Debug\PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" /unregister "IEPageRefresherForRegressionResult\bin\Debug\PageRefresher.dll"
if exist "IEPageRefresherForRegressionResult\bin\Release\PageRefresher.dll" "C:\windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe" /unregister "IEPageRefresherForRegressionResult\bin\Release\PageRefresher.dll"

pause