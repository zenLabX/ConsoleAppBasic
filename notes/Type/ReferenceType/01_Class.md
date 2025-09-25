# C# Reference Type 實例：Class 與物件操作

## Class 宣告範例

```csharp
public class Person
{
    // Field（欄位）
    public string Name;
    public int Age;

    // Property（屬性）
    public string Address { get; set; }

    // Constructor（建構子）
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method（方法）
    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}");
    }
}

## 物件建立
```csharp
Person p1 = new Person("Alice", 25);
Person p2 = p1;  // p2 也是指向同一個物件

p2.Name = "Bob";

Console.WriteLine(p1.Name); // 輸出 "Bob"，因為 p1 與 p2 指向同一個物件

```

## 小提醒
- new 關鍵字：會在 Heap 中建立新的物件。
- 多個變數指向同一物件：修改其中一個會影響其他所有指向它的變數。

## null 與物件釋放
- Reference Type 變數可以為 null。
- 當物件沒有任何變數指向它時，會被 垃圾回收 (GC) 回收。

```csharp
Person p3 = null;    // 變數沒有指向任何物件
```

## 方法中傳遞 Reference Type
```csharp
void UpdatePerson(Person p)
{
    p.Age = 30; // 修改原物件內容
}

Person p4 = new Person("Charlie", 20);
UpdatePerson(p4);
Console.WriteLine(p4.Age); // 30
```

## 釐清用詞

- Pass by Value：傳遞的是「參考的複本」，而不是物件本身。
所以方法內修改物件內容，原物件也會改。

- Pass by Reference (ref / out)：傳遞參考本身，可以讓方法更換變數指向的物件。

```csharp
void ReplacePerson(ref Person p)
{
    p = new Person("Dave", 40);
}

Person p5 = new Person("Eve", 22);
ReplacePerson(ref p5);
Console.WriteLine(p5.Name); // Dave

```

## 開發快速查詢重點
- Reference Type = 堆積區物件 + 指向它的參考變數
- == 比較的是「是否同一個物件」
- 變數賦值 = 複製參考，不是物件
- 可為 null，需注意 NullReferenceException
- 方法參數預設 Pass by Value（複製參考），可用 ref / out 改變指向