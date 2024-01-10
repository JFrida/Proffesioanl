using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////base and first classes
            //Savings_Account savings_Account = new Savings_Account("Mane Sahakyan", 1002);
            //Console.WriteLine(savings_Account.CheckAccountInfo());

            ////second class
            //Checking_Account checking_Account = new Checking_Account("Felix Matevosyan", 1500);
            //Console.WriteLine(checking_Account.CheckAccountInfo());
            //checking_Account.Withdrawal(18000);
            //Console.WriteLine(checking_Account.CheckAccountInfo());

            // third class 
            Fixed_Deposit_Account fixeed = new Fixed_Deposit_Account("Sergey Manvelyan", 1100, new DateTime(2022, 12, 20));
            Console.WriteLine(fixeed.CheckAccountInfo());
            fixeed.Withdrawal(200);
            Console.WriteLine(fixeed.CheckAccountInfo());
            Console.ReadLine();
        }
    }
}
