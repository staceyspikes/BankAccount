using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {


            //public static void getMenu()
            

            Client newClient = new Client("Tyler", "Graves", "July 26 1990", "1426 Imaginary Ave", "135-79-2468");
            CheckingAccount newChecking = new CheckingAccount();
            SavingsAccount newSaving = new SavingsAccount(150);



            Console.WriteLine("Hello, welcome to the big bank of code!");
            Console.WriteLine();
            Console.WriteLine("Please select a number based on the following options");

            string menuFunctions = "1,2,3,4,5";
            do
            {
                Console.WriteLine("1. View client information \n 2. View account balance \n 3. Deposit funds \n 4. Withdraw funds \n  5. Exit");
                string menuSelect = Console.ReadLine();
                switch (menuSelect.ToLower())
                {
                    case "1":
                        newClient.showInfo();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Would you like an account balance for your Checking or Savings?");
                        string accountSelection = Console.ReadLine();
                        if (accountSelection == "Checking")
                        {
                            newChecking.DisplayAccountBalance();
                            Console.WriteLine();
                        }
                        else if (accountSelection == "Savings")
                        {
                            newSaving.DisplayAccountBalance();
                            Console.WriteLine();
                        }
                        
                        break;
                    case "3":
                        Console.WriteLine("Would you like to deposit into your checking or savings account today?");
                        string depositSelection = Console.ReadLine();
                        if (depositSelection == "Checking")
                        {
                            newChecking.DisplayDepositAmount();
                            Console.WriteLine();
                        }
                        else if (depositSelection == "Savings")
                        {
                            newSaving.DisplayDepositAmount();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Please select Checking or Savings");
                            string response = Console.ReadLine();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Would you like to withdraw from your Checking or Savings account today?");
                        string withdrawSelection = Console.ReadLine();
                        if (withdrawSelection == "Checking")
                        {
                            newChecking.DisplayWithdrawAmount();
                            Console.WriteLine();
                        }
                        else if (withdrawSelection == "Savings")
                        {
                            newSaving.DisplayWithdrawAmount();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Please select Checking or Savings");
                            string response = Console.ReadLine();
                        }
                        break;
                    case "5":
                        Console.WriteLine();
                        break;

                }


            } while (menuFunctions != "5" );



                




            }

        
    }

       }
