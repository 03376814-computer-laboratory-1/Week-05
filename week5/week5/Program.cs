using System;


namespace week5
{
    class Program
    {
        public static void Main()
        {

            for (int i = 1; i <= 10; i++)
            {
                string[] monthName = new string[] { "January","February",
            "March","April","May","June","July","August",
            "September","October","November","December"};

                Console.WriteLine("-------- foreach,in loop");
                foreach (string month in monthName)
                {
                    System.Console.WriteLine(month);
                }
                System.Console.WriteLine();

               
                Console.WriteLine("-------- for loop");
                for (int k = 0; k < monthName.Length; k++)
                {
                    System.Console.WriteLine(monthName[i]);
                }
                System.Console.WriteLine();


                
                int count = 0;
                foreach (string month in monthName)
                {
                    count += 1;
                    System.Console.WriteLine("Element #{0}: {1}", count, month);
                }
                System.Console.WriteLine("Number of elements in the array: {0}", count);

                
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();

            }
        }
    }
}

    

    


        
    
    

