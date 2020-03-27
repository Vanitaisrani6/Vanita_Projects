using System;

namespace Abstraction_MethodHiing_
{
    class Employee
    {
        public string FirstNAme;
        public string LastName;

        public void print()
        {
            Console.WriteLine(FirstNAme + " " + LastName);
        }
    }
    class FullTImeEmp :Employee
    { 
    }
    class PArtTimeEmp :Employee
    {
        public new void print()//if we want to hide the base class member the new keyword 
        {// i.e in this case we are making an object of part time employee which in inherited by employee so it will hide print in employee and print print in PTE
            //Console.WriteLine(FirstNAme + " " + LastName + " "+" _Student");
            base.print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            FullTImeEmp FTE = new FullTImeEmp();
            FTE.FirstNAme = "Vanita";
            FTE.LastName = "ISrani";
            FTE.print();



            PArtTimeEmp PTE = new PArtTimeEmp();
            PTE.FirstNAme = "Rohan";
            PTE.LastName = "Israni";
            PTE.print();

        }
    }
}
