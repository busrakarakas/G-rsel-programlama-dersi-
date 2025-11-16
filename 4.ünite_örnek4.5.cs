using System;

class AccountTest
{
   static void Main()
   {
      // create an Account object and assign it to myAccount
      Account myAccount = new Account();

      // display myAccount's initial name 
      Console.WriteLine($"Initial name is: {myAccount.Name}");

      // prompt for and read the name, then put the name in the object
      Console.Write("Please enter the name: "); // prompt
      string theName = Console.ReadLine(); // read a line of text
      myAccount.Name = theName; // put theName in myAccount's Name

      // display the name stored in object myAccount
      Console.WriteLine($"myAccount's name is: {myAccount.Name}");
   }
}
