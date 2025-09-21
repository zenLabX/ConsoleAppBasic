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

## next: 泛型、多型

