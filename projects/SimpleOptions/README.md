# 基本的選項設定 - SimpleOptions 

* 選項類別必須為非抽象，且具有公用的無參數建構函式。
* 程式中，可透過建構函式相依性注入搭配 IOptionsMonitor&lt;TOptions&gt; 來存取。
* 當 appsettings.json 有對應名稱的選項時，會自動套用。如：
```
{
  "option1": "value1_from_json",
  "option2": -1,
}
```
