using System;

namespace NestedStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no to be checked");
            int check = int.Parse(Console.ReadLine());
            Console.WriteLine("original No{0} ",check);
            if (check == 1)
            {
                Console.WriteLine("The no is positive");

            }
            else if (check == 0)
            {
                Console.WriteLine("the no is negative");

            }
            else
            {
                Console.WriteLine("The no is neaural");
            }




        }
    }
}
