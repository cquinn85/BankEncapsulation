using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application, 
            //create a new instance of the BankAccount class. 
           
            var account = new BankAccount();

            //Allow the user of the application to Deposit money
            //and retrieve their balance through the console.

            Console.WriteLine("How much would you like to deposit:");
            var amountToDeposit = double.Parse(Console.ReadLine());

            //call deposit

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you your balance is now ${account.GetBalance()}.");
            
            


        }
    }
}
