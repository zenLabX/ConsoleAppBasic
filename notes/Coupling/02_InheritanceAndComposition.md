## 繼承與組合

這兩個概念似乎都是一起講的，這兩者容易搞混，雖然有不同之處，但繼承與組合都達到程式碼重複使用 (code re-use) 的目的。

### 繼承（inheritance）

繼承就是一個類別（class）可以「延伸」另一個類別，取得它的屬性（fields/properties）和方法（methods），不用重新寫一遍。

- is-a →
  - Dog is a Animal
  - Car is a Vehicle

```csharp
class Animal
{
    public void Eat() { 
        Console.WriteLine("Eating"); 
    }
}


class Dog : Animal  // Dog 繼承 Animal
{
    public void Bark() { 
        Console.WriteLine("Barking"); 
    }
}

```

---

### 組合（composition）

是「某物裡面有另一個物件」，更白話說就是「一個類別擁有另一個類別作為屬性」，跟繼承沒關係。

- has-a → 
  - Dog has a Tail
  - Car has a Engine

```csharp
// 引擎類別
class Engine
{
    public void Start() 
    { 
        Console.WriteLine("Engine starts"); 
    }
}

// 車類別
class Car
{
    // Car has-a Engine
    private Engine engine;

    public Car()
    {
        engine = new Engine();
    }

    public void StartCar()
    {
        Console.WriteLine("Car starts");
        engine.Start(); // 使用組合的物件功能
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartCar();
    }
}


```