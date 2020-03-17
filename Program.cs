using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit casting
            int i = 3;
            float f = i;
            Console.WriteLine("Implicit Casting Result  {0}", f);
            
            // explicit casing using covert method
            int j = 100;
            float k = Convert.ToInt32(i);
            Console.WriteLine("Explicit Casting result  {0}",k);


            //explicit casting using type cast operator (if thw integer value is less then the converted value than the conversion is done using this operator)
            float h = 12356789.88F;
            int m = (int)h;
            Console.WriteLine("Type cast operator Result  {0}",m);

            // Parse and TryParse
            string StrNo = "100";
            int e = int.Parse(StrNo);
            Console.WriteLine("parse result  {0}",i);

            // exception when the string has 100TG i.e TG so we use tryParse
            int result = 0;

            string StrNo1 = "100";
           bool IsConvertedSuccess= int.TryParse(StrNo1, out result);

            if (IsConvertedSuccess)
            {
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Plese enter a valid no");
            }

        }
    }
}
