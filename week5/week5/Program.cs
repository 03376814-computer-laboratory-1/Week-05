﻿using System;


namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 800000000;
            checked // check for overflow
            {
                int square = value * value;
                Console.WriteLine("{0} ^ 2 = {1}", value, square);

            }
        }
    }
}