using System.ComponentModel;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000- DONE

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            ThouToNegativeThou();

            ThreeToNNN();

            EqualIntegers(12,12);

            EvenOrOdd();

            PositiveOrNegative();

            VotingAge(17);

            UserInputTen();

            OneToTwelveMultiplicationTable(56);
        }

        public static void ThouToNegativeThou()
        {
            //Parts of For Loop:
              //for keyword
              //initializer
              //conditional
              //increment
              //scope
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);
        }

        public static void ThreeToNNN()
        {
            for (int t = 3; t <=999; t += 3)
            {
                Console.WriteLine(t);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualIntegers(int e, int f)
        {
            //How to determine if two numbers are equal?
            if(e == f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            int UserInput = int.Parse(Console.ReadLine());
            if (UserInput % 2 == 0)
            {
                Console.WriteLine($"{UserInput} is even.");
            }
            else
            {
                Console.WriteLine($"{UserInput} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            int number = 22;
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool VotingAge(int age)
        {
            if (age >= 18)
            { return true;
            }
            else
            {
                return false;
            }
              
        }
        
        //HU
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool UserInputTen()
        {
            int UserInput10 = int.Parse(Console.ReadLine());

            if (UserInput10 >= -10 && UserInput10 <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void OneToTwelveMultiplicationTable(int num)
        {
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

    }
}
