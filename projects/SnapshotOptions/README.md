# 使用 IOptionsSnapshot 重新載入設定資料 - SnapshotOptions 

* `IOptionsSnapshot<TOptions>` 支援以最小的處理負擔來重新載入選項內容。
* 每一次 request 時，Options 都會重新計算內容值。

執行後，可試著更改 option1 和 option2 的值，並重新整理頁面以即時顯示新值。

