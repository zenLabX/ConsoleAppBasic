using System;

namespace ConsoleAppBasic
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public List<string> Addresses;
        public List<string> Tags;

        // constructor
        public Customer()
        {
            this.Orders = new List<Order>(); //必須在此初始化，否則其他地方引用到，都會報null
            this.Addresses = new List<string>();
            this.Tags = new List<string>();
        }

        // constructor with parameter
        public Customer(int id)
            : this()
        {
            this.Id = id;
        
        }

        // 多載建構子 (Overloading Constructor)，就是「同名但不同參數」的方法。
        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

        //note: this() 這種寫法相對複雜! 建議少用

    }
    
}


