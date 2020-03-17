using System;
class NullAbleTyp

{
    static void main()
    {
        bool AreYouMajor = true;
        if (AreYouMajor == true)
        {
            Console.WriteLine("user is major");
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("user is not a major");

        }
        else
        {
            Console.WriteLine("user did not answer the quuestion");
        }
        }
    
}