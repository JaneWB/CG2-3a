using System;

namespace CG2_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();



            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("What is your birthdate, month and day only");
            Console.WriteLine("Type the month and day of your birthdate: ");
            string birthdate = Console.ReadLine();



            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + ", your birthday is " + birthdate);
            Console.ReadLine();
        }
    }
}
