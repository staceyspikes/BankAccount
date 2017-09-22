using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        public CheckingAccount()
        {

        }

        public CheckingAccount(int accountNumber, double accountBalance, double depositAmount, double withdrawAmount)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Checking account number is {0}:" , accountNumber);
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Checking account balance is {0}:" , accountBalance);
        }
        
        public override void DisplayDepositAmount()
        {
            Console.WriteLine("How much would you like to deposit into your checking account?");
            double depositResponse = double.Parse(Console.ReadLine());
            double currentCheckingBalance = (accountBalance + depositResponse);
            Console.WriteLine("Your new checking account balance is {0}:", currentCheckingBalance);
        }
        public override void DisplayWithdrawAmount()
        {
            Console.WriteLine("How much would you like to withdraw from your checking account?");
            double withdrawResponse = double.Parse(Console.ReadLine());
            double currentCheckingBalance = (accountBalance - withdrawResponse);
            Console.WriteLine("Your new balance is {0}:", currentCheckingBalance);

        }

    }
}
