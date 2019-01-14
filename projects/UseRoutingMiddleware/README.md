# 使用路由中介軟體 - UseRoutingMiddleware 

在 ConfigureServices() 中新增路由服務後，即可在 Configure() 中對路由做客製設定。

AddMvc() 內部已新增路由服務。

建立路由的擴充方法 - [RequestDelegateRouteBuilderExtensions](https://docs.microsoft.com/zh-tw/dotnet/api/microsoft.aspnetcore.routing.requestdelegateroutebuilderextensions?view=aspnetcore-2.1)
