using static NactiData.Services.Operations;
using static NactiData.Display.ConsoleDisplay;

namespace NactiData
{
    internal class Program
    {
        static void Main(string[] args)
        {
           if (args.Count() != 3) {
               throw new Exception("Incorrect input: exactly 3 numbers are expected.");
           }

           int[] numbers = new int[3];

           for (int i = 0; i <= 2 ; i++)
           {
                try
                {
                    numbers[i] = Int32.Parse(args[i]);
                }
                catch (OverflowException)
                {
                    throw new OverflowException($"The number is too large at position {i}: got \'{args[i]}\', Int32 number is expected");
                }
                catch (FormatException)
                {
                    throw new FormatException($"Incorrect input at position {i}: got \'{args[i]}\', Int32 number is expected");
                }
                catch (Exception)
                {
                    throw new Exception("Unknown exception occured");
                }

            }

           int a = numbers[0];
           int b = numbers[1];
           int c = numbers[2];

           Console.WriteLine(Add(a, b, c));
           Console.WriteLine(Multiply(a, b, c));
           Console.WriteLine(AddDivide(a, b, c));
        }
    }
}
