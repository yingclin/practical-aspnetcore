# 路由的條件約束 - RouteConstraint 

針對路由範本檢查相關的路由值，對是否可接受值做出[是/否]決策。

某些路由條件約束會使用路由值以外的資料。例如，HttpMethodRouteConstraint 可以依據其 HTTP 指令動詞接受或拒絕要求。

可用條件可參考 [官方文件](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-2.1#route-constraint-reference)

注意：

路由的條件約束不是用來做輸入驗證的，無效的輸入會導致「404 - 找不到」回應，而不是「400 - 錯誤要求」與適當的錯誤訊息。 它是用來釐清類似的路由，而不是用來驗證特定路由的輸入。