using System.Runtime.ExceptionServices;

namespace IterationStatements3
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintBy3()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);

            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Equal(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is the same as {num2}");

            }
            else
            {
                Console.WriteLine($"{num1} is not the same as {num2}");
            }

        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)

            {
                Console.WriteLine("This number is even");

            }
            else
            {
                Console.WriteLine("This number is odd");


            }

        }

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void WhatIsYourAge()
        {
            Console.WriteLine("What is your age?");
            bool validNumber = int.TryParse(Console.ReadLine(), out int userAge);

            if (userAge < 18)
            {
                Console.WriteLine("Sorry you cant vote, Next!");
            }
            else
            {
                Console.WriteLine("Nevermind! You can Vote!");

            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintBy3();
            Equal(1,2);
            EvenOrOdd(2);
            WhatIsYourAge();


        }
    }
}
