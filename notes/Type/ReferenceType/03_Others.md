# C# Reference Type：其他常用型別與比較

## Interface

- Interface 本身是 Reference Type。
- 變數存放的是物件參考。
- 可以指向任何實作了該 interface 的物件。

```csharp
public interface IWorker
{
    void Work();
}

public class Developer : IWorker
{
    public void Work()
    {
        Console.WriteLine("Coding...");
    }
}

IWorker worker = new Developer();
worker.Work(); // Coding...

```

---

## Delegate

- Delegate 是 Reference Type。
- 可以指向方法，賦值給另一個變數會複製參考。
- 修改 delegate 內容會影響所有持有該 reference 的變數。

```csharp

public delegate void Notify(string message);

void SendMessage(string msg)
{
    Console.WriteLine(msg);
}

Notify notifier = SendMessage;
notifier("Hello"); // Hello


```

---

## Object 型別

- object 是所有型別的基底 Reference Type。
- 可存放任何 Reference Type。
- 需要轉型 (cast) 才能操作原本的屬性或方法。

```csharp

object obj1 = new Person("Alice", 25);
object obj2 = obj1;

((Person)obj2).Name = "Bob";
Console.WriteLine(((Person)obj1).Name); // Bob

```
---

## 小技巧

- 需要比較內容，Reference Type 可 override Equals 或使用 IEquatable<T>。
- interface、delegate、object 都是 Reference Type，要記得賦值只複製參考。
- Reference Type 變數可為 null，使用前建議加 null 檢查。

---

## 開發快速查詢重點

1. Reference Type = Heap 上物件 + 指向它的變數
2. Class / Interface / Delegate / Array / String / Object 都是 Reference Type
3. == 預設比較「同一物件」而不是內容
4. 方法傳遞預設 Pass by Value（複製參考），可以用 ref 改變指向
5. String 是 immutable，Array 與其他 Reference Type 是 mutable
6. Null 可以指向 Reference Type，需小心 NullReferenceException
