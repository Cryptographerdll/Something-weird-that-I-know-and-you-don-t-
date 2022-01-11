using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using ExceptionsLibrary;

namespace Handling_Exceptions_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();

            try
            {
                int result = demo.GrandParentMehod(8);
                Console.WriteLine($"the value of given position is {result}");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("You enter a bad value you are a bad user !!");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var inner = ex.InnerException;

                while (inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }

            Console.ReadLine();
        }
    }
}
