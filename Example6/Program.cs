using System;

namespace Example6
{
    // Fibonacci Numbers: F(n) = F(n-1) + F(n-2)
    class Program
    {
        public static int CalculateFibonacci(int n)
        {
            if (n == 0)
                return 0; //To return the first Fibonacci number

            if (n == 1)
                return 1; //To return the second Fibonacci number

            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine($"Please input a integer!");
                    return;
                }
                // CalculateFibonacci base on the first parameter
                var num = int.Parse(args[0]);
                if (num < 0)
                {
                    Console.WriteLine("The input can not be negative!");
                    return;
                }
                Console.WriteLine(CalculateFibonacci(num));
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine("ErrorMessage:{0}{1}ExceptionType:{2}{1}Assembly:{3}{1}{1}Stack Trace:{1}{4}{1}",
                        ex.Message, Environment.NewLine, ex.GetType(), ex.Source, ex.StackTrace);
                    ex = ex.InnerException;
                }
            }
        }
    }
}
