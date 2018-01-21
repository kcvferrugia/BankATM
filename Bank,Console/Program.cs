using BankATMapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Console
{
    public class Program
    {
        public static string FirstName { get; set; }
        public static int Choice{ get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your bank.\n" +
                "Please enter your account number.");
            var inputAccount = Console.ReadLine();

            var accountService = new AccountService();
            FirstName = accountService.GetAccountName(int.Parse(inputAccount));

            Console.WriteLine($"Thank you, {FirstName}.\n" +
                "Please enter the PIN associated with this account.");

            bool verifyPin = false;
            do
            {
                var inputPin = Console.ReadLine();
                var authService = new AuthService();

                if (authService.VerifyCustomer(int.Parse(inputAccount), int.Parse(inputPin)))
                {
                    verifyPin = true;
                }

                else
                {
                    Console.WriteLine("PIN not verified. Please enter pin again.");
                }
            }
            while (verifyPin == false);

            var accountType = accountService.GetAccountType(int.Parse(inputAccount));
            Console.WriteLine($"{accountType} Account.");

            bool customerIsBanking = true;
            while (customerIsBanking)
            {
                Console.WriteLine("What type of transaction would you like to complete?\n" +
                    "1: Deposit\n" +
                    "2: Withdrawal\n" +
                    "3: Check Balance");
                Console.WriteLine("Choice: ");
                

                switch (Choice)
                {
                    case 1:

                    case 2:

                    case 3:
                        
                    default:
                        Console.WriteLine("Please select from the available options.");
                        break;
                }
            }
        }

        private static bool AnotherTransaction()
        {
            Console.WriteLine("Would you like to make another transaction?\n" +
                           "1: Yes\n" +
                           "2: No");
            var continueTransaction = int.Parse(Console.ReadLine());
            if (continueTransaction == 1)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{FirstName}, thank you for banking with us.");
                return false;
            };
        }

       
      
    }

}
