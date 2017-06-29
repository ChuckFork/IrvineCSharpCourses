using System;
using System.Collections.Generic;
using System.Linq;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please input a student name:");

                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                names.Add(name);
            }

            var maxLen = names.Max(name => name.Length);
            var maxLenNames = names.Where(name => name.Length == maxLen);

            foreach (var maxName in maxLenNames)
            {
                 Console.WriteLine("The longest name is " + maxName + ", which has " + maxLen + " characters");
            }
        }
    }
}
