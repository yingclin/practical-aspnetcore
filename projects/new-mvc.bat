@REM 建立簡單的 MVC 專案
@echo off
@REM check project name
if "%1" == "" goto :msg
@REM create project
echo ** create project : %1
dotnet new web -n %1
cd %1
@REM create HomeController
mkdir Controllers
cd Controllers
copy ..\..\..\tools\MvcHomeController.template.txt HomeController.cs > nul
..\..\..\tools\fart -i -r "HomeController.cs" "{Namespace}" "%1" > nul
cd ..
@REM create Index.cshtml
mkdir Views
cd Views
mkdir Home
cd Home
copy ..\..\..\..\tools\MvcIndexView.template.txt Index.cshtml > nul
..\..\..\..\tools\fart -i -r "Index.cshtml" "{Namespace}" "%1" > nul
cd ..\..
@REM create Startup.cs
copy ..\..\tools\MvcStartup.template.txt Startup.cs > nul
..\..\tools\fart -i -r "Startup.cs" "{Namespace}" "%1" > nul
@REM create README.md
echo # %1 > README.md
echo ** project %1 created.
start dotnet run
start chrome http://localhost:5000
goto :ext
:msg
echo create MVC project
echo usage: new-mvc [Project Name]
:ext