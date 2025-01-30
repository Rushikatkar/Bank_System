using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Bank_System
{
    public class BankingService
    {
        private List<Account> accounts;
        private readonly string filePath = "accounts.json";

        public BankingService()
        {
            accounts = LoadAccountsFromFile();
        }

        // Create Account
        public void CreateAccount()
        {
            Console.Write("Enter Account Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Initial Deposit Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double initialDeposit) || initialDeposit <= 0)
            {
                Console.WriteLine("Invalid deposit amount! Please enter a valid number.");
                return;
            }

            int newAccountNumber = accounts.Count + 1;
            Account newAccount = new Account(newAccountNumber, holderName, initialDeposit);
            accounts.Add(newAccount);

            SaveAccountsToFile();
            Console.WriteLine($"Account created successfully! Your Account Number is {newAccountNumber}");
        }

        // View Account Details
        public void ViewAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accountNumber))
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            Account account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Holder Name: {account.HolderName}");
            Console.WriteLine($"Balance: {account.Balance:F2}");
        }

        // Deposit Money
        public void DepositMoney()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accountNumber))
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            Account account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter Amount to Deposit: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount.");
                return;
            }

            account.Balance += amount;
            SaveAccountsToFile();
            Console.WriteLine($"Successfully deposited {amount:F2}. New Balance: {account.Balance:F2}");
        }

        // Withdraw Money
        public void WithdrawMoney()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accountNumber))
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            Account account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter Amount to Withdraw: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
                return;
            }

            if (amount > account.Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            account.Balance -= amount;
            SaveAccountsToFile();
            Console.WriteLine($"Successfully withdrawn {amount:F2}. Remaining Balance: {account.Balance:F2}");
        }

        // Check Balance
        public void CheckBalance()
        {
            Console.Write("Enter Account Number: ");
            if (!int.TryParse(Console.ReadLine(), out int accountNumber))
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            Account account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine($"Current Balance: {account.Balance:F2}");
        }

        // Save Accounts to File
        private void SaveAccountsToFile()
        {
            string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Load Accounts from File
        private List<Account> LoadAccountsFromFile()
        {
            if (!File.Exists(filePath))
                return new List<Account>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Account>>(json) ?? new List<Account>();
        }
    }
}
