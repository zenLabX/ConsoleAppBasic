using System;

namespace ConsoleAppBasic
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World! bbbb");

            // ex1: 建立 instance 操作裡面的屬性
            // var person = new Person();
            // person.Name = "Yvonne";
            // person.Introduce("Joyce");

            // ex2: instance 物件不能用 person.CompanyName 去存取 class 層級的東西
            var person = Person.ParseMyName("Joyce");
            person.Introduce("Furry");

            // ex3: 來自 Helper.cs
            Helper.MainInHelper("Hello.");

            // ex4: Customer.cs
            var customer = new Customer();
            var order = new Order();
            // customer.Orders = new List<Order>(); // customer.Orders 尚未被初始化時還是null。根據職責份工原則，customer.Orders 不該在此被初始化!!
            customer.Orders.Add(order);
            
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
