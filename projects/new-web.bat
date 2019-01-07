@REM 建立 Razor Pages 專案
@echo off
@REM check project name
if "%1" == "" goto :msg
@REM create project
echo ** create project : %1
dotnet new web -n %1
cd %1
mkdir Pages
cd Pages
dotnet new page -n Index -na %1.Pages
dotnet new viewimports -na %1.Pages
cd ..
copy ..\..\tools\Startup.template.txt Startup.cs > nul
..\..\tools\fart -i -r "Startup.cs" "{Namespace}" "%1" > nul
echo # %1 > README.md
cd ..
echo ** project %1 created.
goto :ext
:msg
echo create Razor Pages project
echo usage: new-web [Project Name]
:ext