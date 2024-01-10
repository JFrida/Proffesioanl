using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Checking_Account : Bank_Account
    {
        private float overDraft;
        public float OverDraft { get { return overDraft; } private set { overDraft = value; } }
        public Checking_Account(string accountOwner, float balance) : base(accountOwner, balance)
        {
            //generate overDraft
            OverDraft = Balance * 10.5f;
        }
        public override string CheckAccountInfo()
        {
            return base.CheckAccountInfo() + $" : Current overDraft for this account is {OverDraft}";
        }
        public override void Withdrawal(float amount)
        {

            var amnt = Balance - amount;
            if (amnt < 0 && OverDraft - Math.Abs(amnt) >= 0)
            {
                Balance = Balance - (amount - Math.Abs(amnt));
                OverDraft = OverDraft - Math.Abs(amnt);
            } 
            else
                Console.WriteLine("Insufficinet funds!");
        }

    }
}

