# 本機開發設定值 - LaunchSettings 

本機開發，透過 dotnet run 或 Visual Studio 執行時，會讀取 Properties\launchSettings.json 來設定適用於本機電腦開發的環境。
* dotnet run : 使用第一個 "commandName": "Project" 的設定部份。
* Visual Studio : 使用 "commandName": "IISExpress" 的設定部份。  

可設定當中的 "ASPNETCORE_ENVIRONMENT" 變數值來取代電腦中預設的值。
