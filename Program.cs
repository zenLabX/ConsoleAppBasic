using System;

namespace ConsoleAppBasic
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World! bbbb");

            Console.WriteLine("\n--- 範例 1: 建立 instance 操作裡面的屬性 ---");
            Example1_InstanceAndProperties();

            Console.WriteLine("\n--- 範例 2: static 屬於 class，不屬於 instance (物件) ---");
            Example2_StaticMembers();

            Console.WriteLine("\n--- 範例 3: 來自 Helper.cs 的方法呼叫 ---");
            Example3_CallHelperMethod();

            Console.WriteLine("\n--- 範例 4: Customer 和 Order 物件的關係 ---");
            Example4_CustomerAndOrder();

        }

        /// <summary>
        /// 範例 1: 建立 instance 操作裡面的屬性
        /// 展示如何建立一個 Person 類別的實例 (instance)，並存取其屬性。
        /// </summary>
        public static void Example1_InstanceAndProperties()
        {
            var person = new Person();
            person.MyName = "Yvonne"; // 設定 Person 物件的 MyName 屬性
            person.Introduce("Joyce"); // 呼叫 Person 物件的 Introduce 方法
        }

        /// <summary>
        /// 範例 2: static 屬於 class，不屬於 instance (物件)
        /// 展示靜態方法 (static method) 如何直接透過類別名稱呼叫，以及如何操作物件實例。
        /// </summary>
        public static void Example2_StaticMembers()
        {
            // 靜態方法 ParseMyName 直接透過類別 Person 呼叫
            var person = Person.ParseMyName("Joyce");
            person.Introduce("Furry");
            // 注意: 不能透過 instance 物件 (person) 去存取 class 層級的靜態成員，例如 Person.CompanyName (如果有的話)
        }

        /// <summary>
        /// 範例 3: 來自 Helper.cs 的方法呼叫
        /// 展示如何呼叫另一個檔案 (Helper.cs) 中定義的靜態方法。
        /// </summary>
        public static void Example3_CallHelperMethod()
        {
            Helper.MainInHelper("Hello from Program.cs!"); // 呼叫 Helper 類別中的 MainInHelper 靜態方法
        }

        /// <summary>
        /// 範例 4: Customer 和 Order 物件的關係
        /// 展示 Customer 和 Order 兩個類別之間的關係，以及處理 NullReferenceException 的一個常見問題。
        /// </summary>
        public static void Example4_CustomerAndOrder()
        {
            var customer = new Customer();
            var order = new Order();
            // 以下這行程式碼可能會導致 NullReferenceException，因為 customer.Orders 尚未被初始化為 List<Order>。
            // 根據職責份工原則，customer.Orders 不該在此被初始化，而應該在 Customer 類別的建構函式中初始化，
            // 或者在使用前進行 null 檢查。
            // customer.Orders = new List<Order>(); // 如果要避免 NullReferenceException，需要初始化 Orders 屬性
            if (customer.Orders == null)
            {
                customer.Orders = new System.Collections.Generic.List<Order>();
            }
            customer.Orders.Add(order);
            Console.WriteLine("Customer added an order.");
        }

    }

    public class Person
    {
        public string MyName;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, I'm {1}.", to, MyName);
        }

        //static 屬於 class，不屬於 instance (物件)
        public static Person ParseMyName(string str)
        {
            var person = new Person();
            person.MyName = str;
            return person;
        }

    }



}
