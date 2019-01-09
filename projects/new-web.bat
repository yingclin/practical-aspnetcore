@REM 建立 Razor Pages 專案
@echo off
@REM check project name
if "%1" == "" goto :msg
@REM create project
echo ** create project : %1
dotnet new web -n %1
cd %1
@REM create pages Index,_Viewimports
mkdir Pages
cd Pages
dotnet new page -n Index -na %1.Pages
dotnet new viewimports -na %1.Pages
copy ..\..\..\tools\RpIndexView.template.txt Index.cshtml > nul
..\..\..\tools\fart -i -r "Index.cshtml" "{Namespace}" "%1" > nul
cd ..
@REM create Startup.cs
copy ..\..\tools\RpStartup.template.txt Startup.cs > nul
..\..\tools\fart -i -r "Startup.cs" "{Namespace}" "%1" > nul
@REM create README.md
echo # %1 > README.md
echo ** project %1 created.
start dotnet run
start chrome http://localhost:5000
goto :ext
:msg
echo create Razor Pages project
echo usage: new-web [Project Name]
:ext