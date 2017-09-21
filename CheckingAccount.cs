using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Account
    {
        public CheckingAccount(int accountNumber, float accountBalance, float withdrawAmount, float depositAmount)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawAmount = withdrawAmount;
            this.depositAmount = depositAmount;
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Checking account number is:" , accountNumber);
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Checking account balance is:" , accountBalance);
        }
        public override void DisplayWithdrawAmount()
        {
            Console.WriteLine("Would you like to withdraw money from your checking account?" );
        }
        public override void DisplayDepositAmount()
        {
            Console.WriteLine();
        }

    }
}
