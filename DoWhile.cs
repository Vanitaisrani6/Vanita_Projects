using System;

namespace DoWhileloop
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            string UserChoice = "";
            do
            {
                Console.WriteLine("plz enter your target?");
                int UserTarget = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;

                }

                do
                {
                    Console.WriteLine("Do you want to contine- Yes or No");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");

            } while (UserChoice == "YES");


        } }
}
