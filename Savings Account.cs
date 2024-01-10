using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Savings_Account : Bank_Account
    {
        public Savings_Account(string accountOwner, float balance) : base(accountOwner, balance) 
        {
        }
    }
}
