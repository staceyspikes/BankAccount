﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Account
    {
        protected double minBalance;

        public double MinBalance
        {
            get { return this.minBalance; }
            set { this.minBalance = value; }
        }
        public SavingsAccount(double minBlance)
        {
            this.minBalance = 150;
            if(accountBalance - withdrawAmount < minBalance)
            {
                Console.WriteLine("Sorry your savings account doesn not have sufficient funds in order to process your withdraw.");
                
            }
            else
            {
                accountBalance -= withdrawAmount;

            }

        }
        public SavingsAccount(int accountNumber, double accountBalance, double depositAmount, double withdrawAmount, double minBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;

        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Your savings account number is {0}:", accountNumber);
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Your savings account balance is {0}:", accountBalance);
        }
        public override void DisplayDepositAmount()
        {
            Console.WriteLine("How much would you like to deposit into your savings account today?");
            double depositResponse = double.Parse(Console.ReadLine());
            double currentSavingsBalance = (accountBalance + depositResponse);
            Console.WriteLine("Your current savings account balance is {0}:", currentSavingsBalance);
        }
        public override void DisplayWithdrawAmount()
        {
            Console.WriteLine("How much would you like to withdraw from your savings?");
            double withdrawResponse = double.Parse(Console.ReadLine());
            double currentSavingsBalance = (accountBalance - withdrawResponse);
            Console.WriteLine("Your current savings account balance is {0}:", currentSavingsBalance);
        }

       
        



    }
}
