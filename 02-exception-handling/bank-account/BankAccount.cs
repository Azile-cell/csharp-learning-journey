using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public BankAccount()
        {
            accountNumber = string.Empty;
            balance = 0;
        }

        public string  AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double GetBalance() 
        {
            return balance;
        }

        public  void Deposit(double amount)
        {
            balance += amount;
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("not enough funds!");
                
            }
            else
            {
                balance -= amount;
            }
        }

        public void Transfer(BankAccount target, double amount)
        {
            try
            {
                Withdraw(amount);

                target.Deposit(amount);
                Console.WriteLine("Transfer of "+ amount+ " to target account is successful");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Transfer failed: "+ ex.Message);
            }

           

           
        }
    }

    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {

        }
    }
    
}
