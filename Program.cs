using System;

namespace HelloWorld
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
