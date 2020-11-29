using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Calculator";
            Console.WriteLine("> Welcome to The Calculator");
            
            string op1, op2;
            double num1, num2, num3;
            List<double> results = new List<double>();

            do
            {
                do
                {
                    Console.Write("> Enter first operator: ");
                    op1 = Console.ReadLine();
                    if (Validate(op1))
                        break;
                    Console.WriteLine("> You have to enter a valid operator");

                } while (true);

                do
                {
                    Console.Write("> Enter second operator: ");
                    op2 = Console.ReadLine();
                    if (Validate(op2))
                        break;
                    Console.WriteLine("> You have to enter a valid operator");

                } while (true);

                do
                {
                    Console.Write("> Enter first term: ");
                    if (double.TryParse(Console.ReadLine(), out num1))
                        break;
                    Console.WriteLine("> You have to enter a number");

                } while (true);

                do
                {
                    Console.Write("> Enter second term: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                        break;
                    Console.WriteLine("> You have to enter a number");

                } while (true);

                do
                {
                    Console.Write("> Enter third term: ");
                    if (double.TryParse(Console.ReadLine(), out num3))
                        break;
                    Console.WriteLine("> You have to enter a number");

                } while (true);

                double result;

                if (op2.ToLower() == "x" || op2 == "*" || op2 == "/")
                {
                    result = GetResult(num2, num3, op2);
                    result = GetResult(num1, result, op1);
                }
                else
                {
                    result = GetResult(num1, num2, op1);
                    result = GetResult(result, num3, op2);
                }

                Console.WriteLine($"> {num1} {op1.ToLower()} {num2} {op2.ToLower()} {num3} = {result}");
                results.Add(result);

                if (result == 100)
                    Console.WriteLine("> Cool, now you have a hundred, clap clap");
                else if (result < 100)
                    Console.WriteLine("> Less then a hundred");
                else
                    Console.WriteLine("> More then a hundred");

                Console.Write("> Another try?(y/n) ");
                string userChoice = Console.ReadLine();
                if (userChoice.ToLower().StartsWith("n"))
                {
                    Console.WriteLine($"> Than you for playing. The sum of all round is {results.Sum()}. Bye");
                    Console.ReadLine();
                    break;
                }

            } while (true);
        }

        static bool Validate(string op)
        {
            if (op == "+" || op == "-" || op.ToLower() == "x" || op == "*" || op == "/")
                return true;
            else
                return false;
        }

        static double GetResult(double a, double b, string op)
        {
            if (op == "+")
                return a + b;
            else if (op == "-")
                return a - b;
            else if (op == "*" || op.ToLower() == "x")
                return a * b;
            else
                return a / b;
        }
    }
}
