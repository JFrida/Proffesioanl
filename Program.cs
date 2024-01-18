using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        delegate decimal DiscountCalculator(decimal totAmount);
        
        static void Main(string[] args)
        {
            // the same with Func
           /* Func<decimal, decimal> discCalc;
            discCalc = RegularCustomerDiscount;
            Console.WriteLine(discCalc(100));*/


            Console.WriteLine("Please input total amout of shopping");
            decimal.TryParse(Console.ReadLine(), out decimal reg);
            DiscountCalculator discountCalculator = RegularCustomerDiscount;
            Console.WriteLine($"Dsicounted amount for regular customer will be {discountCalculator(reg)}");

            Console.WriteLine("Please input total amout of shopping");
            decimal.TryParse(Console.ReadLine(), out decimal vip);
            DiscountCalculator discountCalculator1 = VIPCustomerDiscount;
            Console.WriteLine($"Dsicounted amount for vip customer will be {discountCalculator1(vip)}");

            Console.WriteLine("Please input total amout of shopping");
            decimal.TryParse(Console.ReadLine(), out decimal sales);
            DiscountCalculator discountCalculator2 = VIPCustomerDiscount;
            Console.WriteLine($"Dsicounted amount for summer sales will be {discountCalculator2(sales)}");

            Console.ReadLine();

        }
        static decimal RegularCustomerDiscount(decimal totAmount)
        {
            return totAmount -= totAmount * 0.05m;
        }
        static decimal VIPCustomerDiscount(decimal totAmount)
        {
            return totAmount -= totAmount * 0.15m;
        }
        static decimal SaleDiscount(decimal totAmount)
        {
            return totAmount -= totAmount * 0.3m;
        }
    }
}
