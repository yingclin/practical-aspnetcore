# 被壓平的階層式資料 - FlattenedHierarchicalKey 

Configuration API 取得設定值後，使用分隔符號 `:` (colon) 來壓平(合併)階層式的鍵(機碼)，以管理階層式設定資料。

慣例

* 鍵不區分大小寫。 例如，ConnectionString 與 connectionstring 會被視為相等。
* 若相同機碼的值是由不同提供者提供，會取最後一個套用值。
* 若來源是環境變數，冒號分隔字元可能無法在所有平台上運作。所有平台都支援雙底線 (__)，而且它會被轉換為冒號。

專案中的環境變數測試值是透過 launchSettings.json 提供。 