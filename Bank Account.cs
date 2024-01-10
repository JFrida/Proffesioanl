using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    public abstract class Bank_Account//: IFileWriter
    {
        private int bankId;
        public int BankId { get { return bankId; } private set { bankId = value; } }
        private string accountOwner;
        public string AccountOwner { get { return accountOwner; } private set { accountOwner = value; } }
        private float balance;
        public float Balance { get { return balance; }  set { balance = value; } }

        public Bank_Account(string accountOwner, float balance)
        {
            AccountOwner = accountOwner;
            if (balance > 0)
                Balance = balance;
            else
                throw new ArgumentOutOfRangeException("Preliminary Balance must be grather than 0!");
            //Generating BankId
            foreach (char c in accountOwner)
            {
                BankId += ((int)c);
            }
            BankId = BankId + (int)Balance + (DateTime.Now.Year * DateTime.Now.Month * DateTime.Now.Day);
        }
        public virtual string CheckAccountInfo()
        {
            return ($"Bank Account Id is {BankId}: Acount owned by {AccountOwner}: Current balance is {Balance}");
        }
        public virtual void Withdrawal(float amount)
        {
            if (Balance - amount > 0)
                Balance = Balance - amount;
            else
                Console.WriteLine("Insufficinet funds!");
            return;
        }
        public virtual void Deposit(float amount)
        {
            Balance = Balance + amount;
        }
        //public virtual void WriteInFile(float amount)
        //{
        //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //    // Write the string array to a new file named "WriteLines.txt".
        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Withdrawal.txt")))
        //    {

        //        outputFile.WriteLine($"There was deposit for {BankId} and deposit amount is {amount}");
                
        //    }

        //}
        //public virtual void ReadFromFile() 
        //{
        //    string appendText = "This is extra text" + Environment.NewLine;
        //    string path = @"C:\Users\frida.juharyan\Documents\Withdrawal.txt";
 
        //    File.AppendAllText(path, appendText, Encoding.UTF8);

        //    // Open the file to read from.
        //    string readText = File.ReadAllText(path);
        //    Console.WriteLine(readText);
        //}
    }
}
