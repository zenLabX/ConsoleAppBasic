public ParseExample
{
    //ex1: int.Parse
    try
    {
        var num = int.Parse("xyz")
    }
    catch(Exception)
    {
        Console.WriteLine("Conversion failed.")
    }

    //ex2: int.TryParse
    int number;
    var result = int.TryParse("abc", out number);
    
    if (result)
        Console.WriteLine(number)
    else
        Console.WriteLine("Conversion failed.");

}