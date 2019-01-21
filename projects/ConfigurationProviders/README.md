# 平台內建的設定提供者 - ConfigurationProviders 

應用程式啟動時，會依照順序從提供者順序讀入設定內容。

 CreateDefaultBuilder 使用的典型的提供者順序是：
* 檔案 (appsettings.json、appsettings.{Environment}.json，其中 {Environment} 是應用程式的目前裝載環境)
* 祕密管理員 (僅限開發環境)
* 環境變數
* 命令列參數