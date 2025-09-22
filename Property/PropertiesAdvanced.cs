namespace PropertiesAdvanced
{
    public class Person
    {
        private DateTime Birthdate { get; set; }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

    }

    //模擬實作
    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1976, 1, 1)
            Console.WriteLine("Age",person.Age); //取得結果
        }
    }

}