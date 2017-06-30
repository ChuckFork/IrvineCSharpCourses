using System;
using System.Collections.Generic;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var scoreSheet = new List<KeyValuePair<string, int>>();

                foreach (var item in args)
                {
                    var arr = item.Split(':');
                    if (arr.Length < 2)
                    {
                        Console.WriteLine($"Wrong format of {item},should in format name:score .");
                        continue;
                    }
                    var record = new KeyValuePair<string, int>(arr[0], int.Parse(arr[1]));

                    scoreSheet.Add(record);
                }

                Console.WriteLine("Please input a student name to search score:");

                var name = Console.ReadLine();

                bool flag = false;
                foreach (var record in scoreSheet)
                {
                    if (record.Key == name)
                    {
                        flag = true;
                        Console.WriteLine("The score of " + name + " is " + record.Value);
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine($"Can not find the student with name {name}.");
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
