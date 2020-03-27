using System;

namespace Interface2
{
    using System;

    namespace Interface
    {
        interface ICostumer//i is used just to initialized
        {  //interface has only decalation not implementation and it does not contain fields like int i=10;//default public// multiple inheritance can be implemented using Interface.
            // cannot create an instance of interface i.e cannot create object of the class and abstract classes
            void print();
        }
        interface I2 : ICostumer
        {
            void print2();

        }
        class Costumer : I2
        {
            public void print()
            {
                Console.WriteLine("Print2");

            }

            public void print2()
            {
                Console.WriteLine("Multiple Inheritance");
            }
        }

        class Interface
        {
            static void Main(string[] args)
            {
                Costumer C1 = new Costumer();
                C1.print();
                C1.print2();

            }
        }
    }


}