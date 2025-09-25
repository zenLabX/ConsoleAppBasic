# C# Reference Type 實例：陣列與字串

## 陣列（Array）

```csharp
int[] numbers = { 1, 2, 3 };
int[] copy = numbers;  // 指向同一個陣列
copy[0] = 99;

Console.WriteLine(numbers[0]); // 99
```

### 重點

- 陣列是 Reference Type。
- 賦值只是複製參考，不會複製陣列本身。
- 修改陣列內容會影響所有指向它的變數。

### 建立新陣列（複製資料）

```csharp
int[] clone = (int[])numbers.Clone();
clone[0] = 100;

Console.WriteLine(numbers[0]); // 99
Console.WriteLine(clone[0]);   // 100
```

---

## 字串（String）

```csharp
string s1 = "hello";
string s2 = s1;

s2 = "world";

Console.WriteLine(s1); // "hello"

```

### 重點
- 字串是 Reference Type，但 不可變（immutable）。
- 修改字串會建立新物件，而不是改原本物件。
- 指向字串的變數可以被重新指向其他字串。

### 與方法搭配

```csharp
//陣列
void ChangeArray(int[] arr)
{
    arr[0] = 123;
}

int[] myArr = { 1, 2, 3 };
ChangeArray(myArr);
Console.WriteLine(myArr[0]); // 123

//字串
void ChangeString(string str)
{
    str = "changed";
}

string myStr = "original";
ChangeString(myStr);
Console.WriteLine(myStr); // "original"

```

### 釐清易混淆點
- Array：Reference Type，可直接修改內容。
- String：Reference Type，但 immutable；修改操作會生成新物件。
- 方法傳參考 vs 修改物件內容：
1. Array → 方法內修改內容會影響外部。
2. String → 方法內重新賦值不影響外部。