# 0 個 ASP&#x2E;NET Core 的範例專案

## 目的
把看到的用到的 ASP&#x2E;NET Core 基本開發方式，以簡單實作方式記錄下來。

## 環境

* Windows 10
* .NET Core SDK 2.1.502
* VS Code 1.30.x

### 建立專案：

#### Razor Pages

基本功能實作就用 Razor Pages 即可。

新增空專案
```
dotnet new web -n <專案名稱(會做為根 namespace, 也為輸出目錄)>
```

新增 Pages 目錄，並進入到 Pages 目錄中新增 Index 及 ViewImports。

新增 page : Index
```
dotnet new page -n Index -na <專案名稱(根 namespace)>.Pages
```

新增 MVC ViewImports
```
dotnet new viewimports -na <專案名稱(根 namespace)>.Pages
```

修改 Startup.cs 啟用 MVC
```
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
}
```
```
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    ...
    app.UseMvc();
}
```

或執行 projects 目錄下的 new-web.bat，用法：`new-web <專案名稱(根 namespace)>`

#### MVC 專案

新增 MVC 專案
```
dotnet new mvc -n <專案名稱(會做為根 namespace, 也為輸出目錄)>
```

新增 Web API 專案
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

#### 專案名稱規則
* `P<序號3碼>.<專案名稱>`
* 範例: P000.HelloAspnetCore

專案統一放在 projects 目錄中。

## 專案簡介

### 001 相依性注入

名稱: DependencyInjection


