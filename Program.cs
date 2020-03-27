using System;
public class Employee
{
    public String FirstName="FN", LastName="LN";

    public void PrintFullNAme()
    {
        Console.WriteLine(FirstName + "  " + LastName);
    }
}

namespace Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.PrintFullNAme();

           
        }
    }
}
