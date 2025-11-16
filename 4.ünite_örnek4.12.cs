using System;

class AccountTest
{
   static void Main()
   {
      Account account1 = new Account("Jane Green", 50.00m);
      Account account2 = new Account("John Blue", -7.53m);

      // display initial balance of each object
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      // prompt for then read input
      Console.Write("\nEnter deposit amount for account1: "); 
      decimal depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account1 balance\n");
      account1.Deposit(depositAmount); // add to account1's balance

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");

      // prompt for then read input
      Console.Write("\nEnter deposit amount for account2: ");
      depositAmount = decimal.Parse(Console.ReadLine());
      Console.WriteLine(
         $"adding {depositAmount:C} to account2 balance\n");
      account2.Deposit(depositAmount); // add to account2's balance

      // display balances
      Console.WriteLine(
         $"{account1.Name}'s balance: {account1.Balance:C}");
      Console.WriteLine(
         $"{account2.Name}'s balance: {account2.Balance:C}");
   } 
}
