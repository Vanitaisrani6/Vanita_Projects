using System;

namespace CoalesingOpreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int? Previousvalue =null;
            int AvailableVAlue = Previousvalue ?? 0;
            Console.WriteLine("AvailableVAlue {0}", AvailableVAlue);
        }
    }
}
