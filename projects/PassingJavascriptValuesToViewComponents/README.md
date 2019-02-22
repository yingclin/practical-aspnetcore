# 從 JavaScript 傳值並載入 View components - PassingJavascriptValuesToViewComponents 

除了要傳的資料外，加上 Anti-Forgery Token 做安全檢查。

## 作法

利用 jquery 做 Ajax 呼叫。

注入 Microsoft.AspNetCore.Antiforgery.IAntiforgery 取得 Token 值。

Header 中加上 RequestVerificationToken 送到後端做驗證。

## 參考資料

* https://damienbod.com/2019/01/24/passing-javascript-values-to-asp-net-core-view-components/
