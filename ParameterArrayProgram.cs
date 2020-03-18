using System;

namespace ParameterArray
{
    class ParameterArrayProgram
    {
        public static void ParamsMethod(params int[] Numbers)//param keyword makes the array without passing paramerters in main method
        {
            //for parameter array we use paras keyword
            Console.WriteLine("There are {0} elements", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }


        }
        static void Main(string[] args)
        {

            int[] Numbers = new int[3];
            Numbers[0] = 12;
            Numbers[1] = 300;
            Numbers[2] = 100;

            // ParamsMethod();// output will be no element in array
            ParamsMethod(Numbers);

        }
    }
}

