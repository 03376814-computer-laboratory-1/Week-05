using System;
using System.IO;
    class WhileTest
    {
    static void Main()
    {
    line1:

        Console.Write("Enter your selection (1, 2, or 3): ");
        string s = Console.ReadLine(),P;
        int n = Int32.Parse(s);
        
        switch (n)
        {
            case 1:
                Console.WriteLine("Current value is {0}", 1);
                break;
            case 2:
                Console.WriteLine("Current value is {0}", 2);
                break;
            case 3:
                Console.WriteLine("Current value is {0}", 3);
                break;
            default:
                Console.WriteLine("Sorry, invalid selection.");
                break;
        }
        P = Console.ReadLine();
        if (P == "y")
            goto line1;
        else
        {
            Console.WriteLine("Goodbye");
        }
        // Keep the console open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

