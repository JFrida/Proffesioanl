using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Calculator<T> : ICalculationUtility<T>
    {
        private T value1;
        private T vale2;
        public T Value1 { get { return value1; } set { value1 = value; } }
        public T Value2 { get { return vale2; } set { vale2 = value; } }
        public Calculator(T vale1, T vale2) { Value1 = vale1; Value2 = vale2; }
        public void Addition()
        {
            
            dynamic dynamic1 = Value1;
            dynamic dynamic2 = Value2;
            int first = 0;
            int second = 0;
            if (Value1 is string || Value2 is string)
            {
                if (int.TryParse(dynamic1, out first) && int.TryParse(dynamic2, out second))
                {
                    Console.WriteLine(first + second);
                }
            }
            else
                Console.WriteLine(dynamic1 + dynamic2);

        }
        public void Division()
        {
            dynamic dynamic1 = Value1;
            dynamic dynamic2 = Value2;
            decimal first = 0;
            decimal second = 0;
            if (Value1 is string || Value2 is string)
            {
                if (decimal.TryParse(dynamic1, out first) && decimal.TryParse(dynamic2, out second))
                {
                    var result = (decimal)first / (decimal)second;
                    Console.WriteLine(result);
                }
                else
                {
                    throw new NotSupportedException("Can't do divison with non numeric values");
                }
            }
            else
            {
                var result2= (decimal)dynamic1 / (decimal)dynamic2;
                Console.WriteLine(result2);
            }
                


        }
        public void Multiplication()
        {
            dynamic dynamic1 = Value1;
            dynamic dynamic2 = Value2;
            int first = 0;
            int second = 0;
            if (Value1 is string || Value2 is string)
            {
                if (int.TryParse(dynamic1, out first) && int.TryParse(dynamic2, out second))
                {
                    var result = first*second;
                    Console.WriteLine(result);
                }
                else
                {
                    throw new NotSupportedException("Can't do multiplaction with non numeric values");
                }
            }
            else
            {
                var result2 = dynamic1*dynamic2;
                Console.WriteLine(result2);
            }

        }
        public void Subtraction()
        {
            dynamic dynamic1 = Value1;
            dynamic dynamic2 = Value2;
            int first = 0;
            int second = 0;
            if (Value1 is string || Value2 is string)
            {
                if (int.TryParse(dynamic1, out first) && int.TryParse(dynamic2, out second))
                {
                    var result = first - second;
                    Console.WriteLine(result);
                }
                else
                {
                    throw new NotSupportedException("Can't do subtraction with non numeric values");
                }
            }
            else
            {
                var result2 = dynamic1 - dynamic2;
                Console.WriteLine(result2);
            }

        }

    }
}
