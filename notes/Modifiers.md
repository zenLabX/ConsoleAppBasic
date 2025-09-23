## 🔹 C# Modifiers 速查表 (常用修飾詞)

| 修飾詞 (英文)             | 中文意思   | 功用 / 說明                          | 適用對象                                 |
| -------------------- | ------ | -------------------------------- | ------------------------------------ |
| `public`             | 公開     | 對外部完全可存取                         | Field / Property / Method / Class    |
| `private`            | 私有     | 只能在同一 class 內存取                  | Field / Property / Method / Class 成員 |
| `protected`          | 受保護    | 只能在 class 或子類別存取                 | Field / Property / Method            |
| `internal`           | 內部     | 同一個 Assembly (專案) 可存取            | Field / Property / Method / Class    |
| `protected internal` | 受保護且內部 | 子類別或同 Assembly 可存取               | Field / Property / Method            |
| `private protected`  | 私有受保護  | 同 Assembly 子類別可存取                | Field / Property / Method            |
| `static`             | 靜態     | 屬於 class 本身，共享資料，不需建立物件實例        | Field / Property / Method / Class    |
| `readonly`           | 只讀     | Field 可在宣告或建構子設定一次，之後不可改         | Field                                |
| `const`              | 常數     | Field 編譯時就固定值，不能改，隱含 static      | Field                                |
| `virtual`            | 虛擬     | Property / Method 可被子類別 override | Property / Method                    |
| `override`           | 覆寫     | 子類別覆寫父類別 virtual / abstract 成員   | Property / Method                    |
| `abstract`           | 抽象     | 沒有實作，子類別必須實作                     | Class / Property / Method            |
| `sealed`             | 封閉     | 防止 class 被繼承，或防止 override        | Class / Method / Property            |
| `volatile`           | 易變     | 告訴編譯器該 field 可能被多執行緒修改           | Field                                |
| `unsafe`             | 不安全    | 允許使用指標操作                         | Field / Method / Class               |
| `partial`            | 部分     | class / method 可以分開多個檔案定義        | Class / Method                       |
