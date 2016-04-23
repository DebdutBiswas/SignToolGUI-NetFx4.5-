title SignAPI CommandLine Interface
@echo off
cls
color 02
prompt SignAPI~SignPath 
SignAPI.exe /?
echo.
SignAPI.exe sign /?
echo.
echo Now starting SignTool Commandline Interface...
echo Press any key to continue...
pause>nul
cls
cmd /k "cls"