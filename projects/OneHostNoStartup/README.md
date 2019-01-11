# 不用 Startup.cs - OneHostNoStartup

AddXXX : 
要 using Microsoft.Extensions.DependencyInjection

UseXXX : 要 using Microsoft.AspNetCore.Builder   

多次呼叫 ConfigureServices 會彼此附加。 多個呼叫 Configure 則使用最後一個方法呼叫。 
