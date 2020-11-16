using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";

            do
            {
                Console.Write("> Enter first operator: ");
                string op1 = Console.ReadLine();
                Console.Write("> Enter second operator: ");
                string op2 = Console.ReadLine();
                Console.Write("> Enter first term: ");
                double.TryParse(Console.ReadLine(), out double num1);
                Console.Write("> Enter second term: ");
                double.TryParse(Console.ReadLine(), out double num2);
                Console.Write("> Enter third term: ");
                double.TryParse(Console.ReadLine(), out double num3);

                double result = 0;

                if (op1 == "+")
                {
                    if (op2 == "+") result = num1 + num2 + num3;
                    else if (op2 == "-") result = num1 + num2 - num3;
                    else if (op2 == "x") result = num1 + num2 * num3;
                    else result = num1 + num2 / num3;
                }
                else if (op1 == "-")
                {
                    if (op2 == "+") result = num1 - num2 + num3;
                    else if (op2 == "-") result = num1 - num2 - num3;
                    else if (op2 == "x") result = num1 - num2 * num3;
                    else result = num1 - num2 / num3;
                }
                else if (op1 == "*")
                {
                    if (op2 == "+") result = num1 * num2 + num3;
                    else if (op2 == "-") result = num1 * num2 - num3;
                    else if (op2 == "x") result = num1 * num2 * num3;
                    else result = num1 * num2 / num3;
                }
                else
                {
                    if (op2 == "+") result = num1 / num2 + num3;
                    else if (op2 == "-") result = num1 / num2 - num3;
                    else if (op2 == "x") result = num1 / num2 * num3;
                    else result = num1 / num2 / num3;
                }

                Console.WriteLine($"> {num1} {op1} {num2} {op2} {num3} = {result}");
                List<double> results = new List<double>();
                results.Add(result);

                if (result == 100)
                    Console.WriteLine("\n> Cool, now you have a hundred, clap clap");
                else if (result < 100)
                    Console.WriteLine("\n> Less then a hundred");
                else
                    Console.WriteLine("\n> More then a hundred");

                Console.Write("Another try?(y/n) ");
                string userChoice = Console.ReadLine();
                if (userChoice.ToLower().StartsWith("n"))
                {
                    Console.WriteLine($"> Than you for playing. The sum of all round is {results.Sum()}. Bye");
                    break;
                }

            } while (true);
        }
    }
}
