using System;

namespace Loops
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the No to be checked");
            int n = int.Parse(Console.ReadLine());
           
            if ((n == 0) || (n == 1))
            {
                Console.WriteLine("one and zero are not prime no");

            }
           
            else if (n % 10 == 0)
            {
                Console.WriteLine("The no. is not a prime no.");

            }
            else
            {
                Console.WriteLine("The no is prime no");
            }
        }
    }
}
