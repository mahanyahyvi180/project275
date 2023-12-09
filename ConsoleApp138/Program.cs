using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp138
{
    class Program
    {
        static void Main(string[] args)
        {
            var continueLoop = true;

            do
            {

                try
                {

                    Console.Write("Enter an integer numerator:");
                    var numerator = int.Parse(Console.ReadLine());
                    Console.Write("Enter an integer denominator:");
                    var denominator = int.Parse(Console.ReadLine());


                    var result = numerator / denominator;

                    Console.WriteLine($"\nResult:{numerator}/{denominator}={result}");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine($"\n{formatException.Message}");
                    Console.WriteLine("you must enter two integers.please try again.\n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"\n{divideByZeroException.Message}");
                    Console.WriteLine("zero is an invalid denominator.please try again.\n");
                }
            } while (continueLoop);

        }
    }
}
