using System;

namespace EvenNos
{
    class Methods
    {
        public static void  EvenNo(int Target)
        {
            int Start = 0;
            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
            }
        }
        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        static void Main(string[] args)
        {
            Methods.EvenNo(30);
            Methods h = new Methods();
            int sum=h.Add(10, 20);
            
            Console.WriteLine("Addition Result  {0}",sum);


        }
    }
}
