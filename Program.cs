﻿using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amt to withdraw");
            string val = Console.ReadLine();
            int amt = Convert.ToInt32(val);
            Console.WriteLine("Input= {0}", amt);
            

        }
    }
}
