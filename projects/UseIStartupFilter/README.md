# 用 IStartupFilter 註冊中介軟體 - UseIStartupFilter 

透過 IStartupFilter 註冊的中介軟體會比 Startup.Configure() 中註冊的還早被呼叫，有助於確保某個中介軟體會在應用程式要求處理管線(pipeline)的開頭或結尾被執行。
