# 8 個 ASP&#x2E;NET Core 的基本功能範例專案

## 目的
把看到的用到的 ASP&#x2E;NET Core 基本功能，以實作方式記錄下來。

## 環境

* Windows 10
* .NET Core SDK 2.1.503
* VS Code 1.30.x

### 建立專案：

#### Razor Pages

基本功能實作就用 Razor Pages 即可。

建立無靜態檔的簡易專案：
* 執行 projects 目錄下的 new-web.bat，用法：`new-web <專案名稱(根 namespace)>`。
* 會自動執行 dotnet run 及開啟瀏覽器，待啟動完成後重整瀏覽器。

#### MVC 專案

建立無靜態檔的簡易專案：
* 執行 projects 目錄下的 new-mvc.bat，用法：`new-mvc <專案名稱(根 namespace)>`。
* 會自動執行 dotnet run 及開啟瀏覽器，待啟動完成後重整瀏覽器。

建立完整 MVC 專案
```
dotnet new mvc -n <專案名稱(會做為根 namespace, 也為輸出目錄)>
```

#### Web API 專案

建立完整 Web API 專案
```
dotnet new webapi -n <專案名稱(會做為根 namespace, 也為輸出目錄)>
```

### 執行專案
```
dotnet run
```

* 開啟 Razor Pages : http://localhost:5000/
* 開啟 MVC : https://localhost:5001/
* 開啟 Web API : https://localhost:5001/api/Values

專案統一放在 projects 目錄中。

## 專案列表

### 平台基礎

#### 啟動

* 不用 Startup.cs -- 
[OneHostNoStartup](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/OneHostNoStartup)

    WebHost 可取代 Startup 的 ConfigureServices() 和 Configure()。

* 用 IStartupFilter 註冊中介軟體 -- 
[UseIStartupFilter](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/UseIStartupFilter)

    用 IStartupFilter 註冊中介軟體，以確保在處理管線的開頭或結尾執行。   

#### 相依性注入

* 基本相依性注入 -- 
[DependencyInjection](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/DependencyInjection)

* 平台提供的內建服務 -- 
[FrameworkProvidedDIServices](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/FrameworkProvidedDIServices)

    應用程式初始化後，使用 IServiceCollection 已提供一些內建服務。

* 動態建立物件 -- 
[ActivatorUtilities](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/ActivatorUtilities)

    動態建立物件，並支援該物件的相依性注入。

#### 路由

* 啟用路由中介軟體 -- 
[UseRoutingMiddleware](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/UseRoutingMiddleware)

* 用 DataTokens 定義路由屬性 -- 
[UsingRouteDataTokens](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/UsingRouteDataTokens)  

* 路由的條件約束 -- 
[RouteConstraint](https://github.com/yingclin/practical-aspnetcore/tree/master/projects/RouteConstraint)  

### Web 應用程式

### Web API

### SignalR

