using System;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 255: ");

            string n1 = Console.ReadLine();

            Console.WriteLine("Enter another number between 0 and 255: ");

            string n2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(n1);
                int num2 = Int32.Parse(n2);
                int ans = Int32.Parse(n1) / Int32.Parse(n2);


            }
            catch (FormatException)
            {
                Console.WriteLine("\nFormatException: " + e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException: " + e.Message);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nArgumentOutOfRangeException: " + e.Message);
            }

            Console.WriteLine("\n" + n1 + " divided by " + n2 + " is " + Int32.Parse(n1) / Int32.Parse(n2));


            Console.WriteLine("\nHave a great day!");
        }
    }
}
