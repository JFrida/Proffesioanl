using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Check for int
            Calculator<int> calculator = new Calculator<int>(12, 14);
            calculator.Addition();
            calculator.Division();
            calculator.Multiplication();
            calculator.Subtraction();

            // Check for decimal
            Calculator<decimal> calculator2 = new Calculator<decimal>(12.2m, 14.8m);
            calculator2.Addition();
            calculator2.Division();
            calculator2.Multiplication();
            calculator2.Subtraction();


            // Check for string
            // if one of properties can't be possible to convert int then we will have exceptions for last three functions
            Calculator<string> calculator1 = new Calculator<string>("46", "45");
            calculator1.Addition();
            calculator1.Division();
            calculator1.Multiplication();
            calculator1.Subtraction();

            Console.ReadLine();
        }
    }
}
