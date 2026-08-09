using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            BankAccount bankAccount = new BankAccount();
            try
            {

                Console.Write("Enter amount to deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                account.Deposit(amount);
                Console.WriteLine("Balance after deposit: "+ account.GetBalance());

                Console.Write("\nEnter amount to withdraw: ");
                int amountWithdrawn = Convert.ToInt32(Console.ReadLine());
                account.Withdraw(amountWithdrawn);
                Console.WriteLine("Balance after withdrawal: "+ account.GetBalance() );

                Console.Write("enter another amount to withdraw, make sure it's more than balance: ");
                int amountWithdrawnOver = Convert.ToInt32(Console.ReadLine());
                account.Withdraw(amountWithdrawnOver);

                account.Transfer(bankAccount, amountWithdrawn);

            }
            catch (FormatException exception)
            {
                Console.WriteLine("input format error: " + exception.Message);
            }
            catch (InsufficientFundsException message)
            {
                Console.WriteLine("insufficient funds error: " + message.Message);

            }
            finally
            {
                Console.WriteLine("Transaction Complete");
            }

            Console.ReadKey();
        }
    }
}
