using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        protected int accountNumber;
        protected float accountBalance;
        protected float withdrawAmount;
        protected float depositAmount;

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
        public float AccountBalance
        {
            get { return this.accountBalance; }
        }
        public float WithdrawAmount
        {
            get { return this.withdrawAmount; }
        }
        public float DepositAmount
        {
            get { return this.depositAmount; }
        }

        public Account()
        {

        }
        public Account(int accountNumber, float accountBalance, float withdrawAmount, float depositAmount)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawAmount = withdrawAmount;
            this.depositAmount = depositAmount;

        }

        public virtual void DisplayAccountNumber()
        {

        }
        public virtual void DisplayAccountBalance()
        {

        }
        public virtual void DisplayWithdrawAmount()
        {

        }
        public virtual void DisplayDepositAmount()
        {

        }
    }
}
