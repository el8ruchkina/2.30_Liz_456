using System;
public class mainclass
{
    public static void Main()
    {
        int x1, x0, a, b;
        Console.WriteLine("Число x после преобразований равно 456");
        x1 = 456;
        b = 456 % 10;
        x1 = 456 - b;
        a = (x1 % 100)/10;
        x0 = x1 - (a*10) + b*10 + a;
        Console.WriteLine($"Иcходный x равен {x0}");
    }
}