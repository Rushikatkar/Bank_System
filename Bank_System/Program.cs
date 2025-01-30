using Bank_System;
BankingService bankingService = new BankingService();

while (true)
{
    Console.WriteLine("\n--- Banking System ---");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. View Account Details");
    Console.WriteLine("3. Deposit Money");
    Console.WriteLine("4. Withdraw Money");
    Console.WriteLine("5. Check Balance");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            bankingService.CreateAccount();
            break;
        case "2":
            bankingService.ViewAccountDetails();
            break;
        case "3":
            bankingService.DepositMoney();
            break;
        case "4":
            bankingService.WithdrawMoney();
            break;
        case "5":
            bankingService.CheckBalance();
            break;
        case "6":
            Console.WriteLine("Exiting... Thank you for using our banking system.");
            return;
        default:
            Console.WriteLine("Invalid choice! Please enter a valid option.");
            break;
    }
}