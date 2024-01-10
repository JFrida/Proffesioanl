using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Fixed_Deposit_Account: Bank_Account
    {
        private DateTime maturity;
        public DateTime Maturity { get { return maturity; } private set { maturity = value; } }
        private DateTime creationDate;
        public DateTime CreationDate { get { return creationDate; } private set { creationDate = value; } }
        public Fixed_Deposit_Account(string accountOwner, float balance, DateTime creationDate) : base(accountOwner, balance)
        {

            CreationDate = creationDate;
            //generate maturity
            Maturity = CreationDate.AddYears(1);

        }
        public override string CheckAccountInfo()
        {
            return base.CheckAccountInfo() + $" : Current Maturity Date for this account is {Maturity}";
        }
        public override void Withdrawal(float amount)
        {
            if (Maturity.Date <= DateTime.Now.Date)
            {
                base.Withdrawal(amount);
                //base.WriteInFile(amount);
                //base.ReadFromFile();
            }
            else
                Console.WriteLine("Wasn't passed 1 year");
        }
    }
}
