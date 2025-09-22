## 0919 class, static, instance
1. 建立 primitive type 速查表
2. 學到 static 是屬於 class 層級的東西，instance 取不到

## 0921 建構子 (constructor) 
範例使用 Customer.cs
- constructor 是在 class 建立後被呼叫的函式 (非必要函式)
- 可在此初始化該 class 的屬性
- constructor 的名稱要跟 class 一樣 (名稱跟class一樣就會被判定為建構子)
- constructor 沒有返回類型，甚至沒有 void

## 0921 Methods (見 Point.cs)
- overloading methods
- 學習 class 中的 methods 如何去寫能更整潔

## 0921 Parse & TryParse (見 ParseExample.cs)
額外補充：
- Parse: 需要包在 try catch 之中，否則可能出 exception 導致系統 crash!
- TryParse: 會回傳布林值，不會報錯

## 0922 Field
- List 屬性直接被初始化的用法
- readonly 修飾欄位後，該欄位只能在宣告時或建構子中被初始化，程式其他地方不能重新指派；欄位指向的物件內容仍可修改。

## 0922 OOP programming 的反思
- Q: 為什麼 OOP Programming 需要封裝？(encapsulation)
- A: 封裝的目的就是 保護資料、隱藏實作、控制存取，讓程式更安全、模組化、易維護。

### 1. 保護資料（Data Protection）
- 封裝可以把物件的屬性（Fields）設為 private，不讓外部程式直接修改
- 透過 Getter / Setter 方法控制對資料的存取與修改，避免資料被亂用或破壞。
- 例如：銀行帳戶的 balance 不應該被隨意改寫，必須透過 Deposit() 或 Withdraw() 方法處理。

### 2. 提高模組化（Modularity）
- 封裝讓物件內部的實作細節對外部隱藏，只提供必要介面（Interface）。
- 外部程式只需知道怎麼「使用」物件，而不用管內部怎麼運作。
- 這樣程式維護與修改就更容易，內部邏輯改變不會影響外部使用者。

### 3. 增加可讀性與可維護性
- 封裝將資料和操作方法綁在一起，物件本身就是一個獨立的單位。
- 讓程式結構更清楚，閱讀與除錯更容易。

### 4. 支持多型與彈性擴充
- 透過封裝，子類別可以在不影響外部程式的情況下修改或擴充內部行為。
- 這讓物件導向設計更靈活，也符合資訊隱藏原則（Information Hiding）。

## OOP 的重點
物件導向的核心是行為優先，內部實作隱藏，對外只暴露功能，這正是封裝的精髓。

---

## Class 中的易混淆觀念：Field、Property、Getter/Setter、Method 的關係

### Field
class 內部「真實存資料的地方」，「被包起來的資料」就是欄位（Field），原則上是不應該對外開放的。要存取資料，就必須透過固定的手續：getter 與 setter（讀取式與儲存式）。所謂的屬性（Property）就是被 getter, setter 封裝起來的欄位。

- 來源：https://eric-yijuin-lin.medium.com/c-%E6%AC%84%E4%BD%8D-field-%E8%88%87%E5%B1%AC%E6%80%A7-property-%E7%9A%84%E5%B7%AE%E5%88%A5-7e7fd3584b02

### Property | Getter/Setter | Method
- Getter/Setter: 目的是做資料的檢查跟存取，不做複雜的邏輯處理與運算。
- Method: 代表物件的行為，可以做複雜的運算或與其他物件溝通。


## next: 泛型、多型

