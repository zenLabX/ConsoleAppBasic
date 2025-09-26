## 總結

學了高耦合、低耦合的觀念，又學了繼承與組合這兩個概念後，可以發現幾個重點：

### 1️⃣ 繼承（Inheritance） → 高耦合（Tightly Coupled）

- 子類別依賴父類別的實作細節
- 父類別改變時，子類別也可能需要修改
- 優點：程式碼重用方便
- 缺點：靈活性低、耦合度高

```csharp
class Animal
{
    public void Eat() { 
        Console.WriteLine("Eating"); 
    }
}

class Dog : Animal // 高耦合
{
    public void Bark() { 
        Console.WriteLine("Barking"); 
    }
}

```

如果 Animal 改 Eat() 實作，Dog 可能受影響

---

### 2️⃣ 組合（Composition） → 低耦合（Loosely Coupled）

- 類別之間透過「擁有」關係互動，而不是繼承
- 只依賴對方的介面或功能，而不是內部實作
- 優點：靈活、容易替換或修改
- 缺點：需要額外的封裝（可能多寫一些 getter/setter 或方法呼叫）

```csharp
class Engine
{
    public void Start() { 
        Console.WriteLine("Engine starts"); 
    }
}

class Car
{
    private Engine engine; // 低耦合

    public Car(Engine engine) { 
        this.engine = engine; 
    }

    public void StartCar() { 
        engine.Start(); 
    }
}

```

如果 Engine 改變內部實作，只要介面不變，Car 不需要改

---

## 總結：
- 繼承 → 高耦合 → 適合「is-a」且父類別穩定
- 組合 → 低耦合 → 適合「has-a」且需要彈性或可替換性