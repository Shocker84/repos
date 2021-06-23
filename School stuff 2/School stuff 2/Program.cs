using System;

namespace School_stuff_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int[] arr = {1, 2, 3, 4, 5};

              for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write(arr[i] + " ");
              }

              try
              {
                  Console.WriteLine(arr[7]);
              }
              catch (IndexOutOfRangeException e)
              {
                  Console.WriteLine("An IndexOut OfRangeException has occured: {0} {1} {2} {1}",
                          e.Message, 77, 123);
              }

              catch (Exception e)
              {
                  Console.WriteLine("An Exception has occured: {0}", e.Message);
              }
              */

            int[] arr2 = { 19, 2, 75, 52 };

            try
            {
                for (int i = 0; i < arr2.Length - 1; i++)
                {
                    Console.WriteLine(arr2[i] / arr2[i + 1]);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.Write("finally block");
                for(int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                }
            }



            Console.WriteLine("\n\nHave a nice day!");
        }
    }
}
