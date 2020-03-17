using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 10:
                    Console.WriteLine("your no is 10");
                    break;
                    case 11:
                    Console.WriteLine("your no is 11");
                    break;
                default:
                    Console.WriteLine("Invalid No");
                    break;

            }

        }
    }
}
