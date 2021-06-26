using System;

namespace School_practice
{
    class Program
    {

       
        static void Main(string[] args)
         
        
        {

            // Console.WriteLine("Hello World!");

              Console.WriteLine("\n\n");
              Console.WriteLine("| Type | Bytes of Memory | Min | Max |");
              Console.WriteLine("================================================");
              Console.WriteLine("|  sbyte | " + sizeof(sbyte) + " | " + sbyte.MinValue + " |" + sbyte.MaxValue + " |");
              Console.WriteLine("|  byte | " + sizeof(byte) + " | " + byte.MinValue + " |" + byte.MaxValue + " |");
              Console.WriteLine("|  float | " + sizeof(float) + " | " + float.MinValue + " |" + float.MaxValue + " |");
              Console.WriteLine("|  double | " + sizeof(double) + " | " + double.MinValue + " |" + double.MaxValue + " |");
              Console.WriteLine("|  long | " + sizeof(long) + " | " + long.MinValue + " |" + long.MaxValue + " |");
              Console.WriteLine("|  decimal | " + sizeof(decimal) + " | " + decimal.MinValue + " |" + decimal.MaxValue + " |");
            



            int length = 100;
            
            for (int i = 1; i <= length; i++)
            {
                if (i % 3== 0 && i % 5 ==0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                    Console.Write(i);

                if (i == 100)
                {
                    Console.WriteLine(".");
                }
                else 
                {
                    Console.WriteLine(", ");
                }

               if (i % 15 == 0)
                    {
                        Console.Write("\n");
                    }
            }
        }
    }
}
