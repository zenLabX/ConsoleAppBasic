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

「封裝」是物件導向程式設計中的一個基本、但是重要的概念。簡單來說，就是物件的資料要被包起來，想要存取資料都必須經過固定的手續。

---

## Class 中的易混淆觀念：Field、Property、Getter/Setter、Method 的關係

Property 程式碼在 Property 資料夾。

### Field
class 內部「真實存資料的地方」，「被包起來的資料」就是欄位（Field），原則上是不應該對外開放的。(但透過固定的程序就可以取用到)

- 來源：https://eric-yijuin-lin.medium.com/c-%E6%AC%84%E4%BD%8D-field-%E8%88%87%E5%B1%AC%E6%80%A7-property-%E7%9A%84%E5%B7%AE%E5%88%A5-7e7fd3584b02

## Property 
property 是語法糖，透過 property 可以更有效快速的取用 field 的值。

### Property | Getter/Setter | Method
- Property: 語法糖，它包裝了 Getter 和 Setter，讓外部看起來像在存取變數，但其實背後是 method 在跑。
- Getter/Setter: 做資料的檢查跟存取，不做複雜的邏輯處理與運算。可以被視為一種 method。
- Method: 代表物件的行為，可以做複雜的運算或與其他物件溝通。

```
外部程式
   │
   ▼
Property (中繼站，看起來像變數，但背後是 get/set 方法)
   │
   ▼
Field (真正儲存資料的地方)
```

---


## 0923 Modifiers 修飾詞速查表

常常看到很多這種 "public", "private" 散落在各處，但不了解全貌、總共到底有哪些，還有用法，這邊利用表格做一個歸納，可查 `Modifiers.md`。

### 🔹 簡單記憶法

- 存取修飾詞 (Access) → public / private / protected / internal

- 狀態/行為修飾詞 (Behavior) → static / readonly / const / volatile / unsafe

- 繼承/多型修飾詞 (Inheritance/Polymorphism) → virtual / override / abstract / sealed

- 檔案/拆分修飾詞 → partial

---

## 0925 低耦合程式架構的特性

### 基礎知識點釐清
1. 重新釐清 type 有分 reference type 跟 value type
2. modifiers 與 type 之間的關係
3. 釐清原來 interface 是一種 reference type

### 學習高耦合
- Q: 什麼是高耦合？
- A: 高耦合就是，程式碼之間有高度的依附性，範例可以查 `TightlyCoupled.cs`
- Tightly coupled = 直接依賴具體實作 → 改一個牽動一大片。
- Loosely coupled = 依賴抽象 (interface/抽象類別) → 彈性大、維護容易。

要做出這樣的架構需要理解以下

- 封裝 (Encapsulation)
- classes 之間的關係
- 介面 interfaces


---

## next: 泛型、多型

