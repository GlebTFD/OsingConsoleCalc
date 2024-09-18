using System;
using System.Data;

namespace Osing_Console_Calc
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.StartsWith("calc "))
            {
                string expression = input.Substring(5);
                expression = expression.Replace("+", " + ");
                expression = expression.Replace("-", " - ");
                expression = expression.Replace("*", " * ");
                expression = expression.Replace("/", " / ");
                try
                {
                    var dataTable = new DataTable();
                    var result = dataTable.Compute(expression, string.Empty);
                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Please enter 'calc' followed by an expression.");
            }
        }
    }
}