# 命令列設定提供者 - CommandLineConfigurationProvider 

CommandLineConfigurationProvider 會在執行階段從命令列參數載入設定。

## 參數形式：
* CommandLineKey1=value1
* --CommandLineKey2=value2、--CommandLineKey2 value2
* /CommandLineKey3=value3、/CommandLineKey3 value3

在同一個執行中，不要混用不同形式。

## 切換對應字典
當有提供切換對應字典時，會查找字典中是否有任何鍵符合命令列參數所提供的鍵，並設定查找到的參數內容。

切換對應字典索引鍵規則：
* 以單虛線 (-) 或雙虛線 (--) 開頭。
* 不能包含重複索引鍵。
* 索引值就是對應的參數名，如 Key:-CLKey2,Value:CommandLineKey2。

## 執行範例
```
dotnet run CommandLineKey1=value1 -CLKey2=value2
```