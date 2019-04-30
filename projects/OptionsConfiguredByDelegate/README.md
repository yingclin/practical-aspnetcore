# 使用委派(delegate)來設定簡單的選項 - OptionsConfiguredByDelegate 

類似於 SimpleOptions 專案，但在 Startup.cs 中初始化時，改用 delegate 寫法。

* 雖然在 appsettings.json 中有設定值，但 Options 中值會被 delegate 所指定的初始值所覆寫。


