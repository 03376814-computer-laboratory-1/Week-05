using System;
public class TryCatch
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 10;
        b /= a;
        Console.WriteLine(a);
        Console.ReadKey();
    }
}