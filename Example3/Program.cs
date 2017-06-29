using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count = args.Length;
                if (count < 3)
                {
                    throw new ArgumentException($"count of arguments must greater than three,current count = {count}");
                }
                var op = args[0];

                var a = int.Parse(args[1]);
                var b = int.Parse(args[2]);

                switch (op.ToLower())
                {
                    case ("add"):
                        Console.WriteLine(a + b);
                        break;
                    case ("subtract"):
                        Console.WriteLine(a - b);
                        break;
                    case ("multiply"):
                        Console.WriteLine(a * b);
                        break;
                    case ("divide"):
                        Console.WriteLine((double)a / b);
                        break;
                    default:
                        Console.WriteLine("Unknonw operator:" + op);
                        break;
                }
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
