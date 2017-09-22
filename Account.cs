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
        protected double accountBalance;
        protected double depositAmount;
        protected double withdrawAmount;

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        public double DepositAmount
        {
            get { return this.depositAmount; }
        }
        public double WithdrawAmount
        {
            get { return this.withdrawAmount; }
        }

        public Account()
        {

        }
        public Account(int accountNumber, double accountBalance, double depositAmount, double withdrawAmount)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;

        }

        public virtual void DisplayAccountNumber()
        {

        }
        public virtual void DisplayAccountBalance()
        {

        }
        public virtual void DisplayDepositAmount()
        {

        }
        public virtual void DisplayWithdrawAmount()
        {

        }
    }
}
