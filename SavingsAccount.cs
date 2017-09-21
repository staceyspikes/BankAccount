using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        protected float minBalance;

        public float MinBalance
        {
            get { return this.minBalance; }
        }
        public SavingsAccount(int accountNumber, float accountBalance, float withdrawAmount, float depositAmount )
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawAmount = withdrawAmount;
            this.depositAmount = depositAmount;

        }
        public override void DisplayAccountNumber()
        {

        }
        public override void DisplayAccountBalance()
        {

        }
        public override void DisplayWithdrawAmount()
        {

        }
        public override void DisplayDepositAmount()
        {

        }



    }
}
