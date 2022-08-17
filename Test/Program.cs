using Test;

public class Program
{
    public static void Main(string[] args)
    {
        var x = 1;
        var y = 1;
        var calc = new Calculator();
        var result = calc.Divide(x, y);
        Console.WriteLine(result); 
    }

    
}
