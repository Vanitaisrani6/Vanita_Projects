using System;

class Consumer
    {
    string FirstName,LaseName;
    public Consumer(string FN,string LN)

    {
        this.FirstName = FN;
        this.LaseName = LN;

    }
    public void PrintingFullNAme()
    {
        Console.WriteLine("Full Name {0}", this.FirstName + " " + this.LaseName);

    }
    ~Consumer()
    { 
        // clean up code
    }

}
namespace Classes
{
    class Program
    {
        static void Main()
        {
            Consumer c1 = new Consumer("Vanita" , "Israni");
            c1.PrintingFullNAme();
        }
    }
}
