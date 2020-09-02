using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application, 
            //create a new instance of the BankAccount class. 
            //In the Main method, create an instance of the PersonalInformation class 
             
            


            var account = new BankAccount();
            var customerInfo = new PersonalInformation();

            //Allow the user of the application to Deposit money
            //and retrieve their balance through the console.

            Console.WriteLine("How much would you like to deposit:");
            var amountToDeposit = double.Parse(Console.ReadLine());

            //and ask the user to input their phone number,

             Console.WriteLine("Please provide your phone number:"); 

            var memberNumber = int.Parse(Console.ReadLine());//(this line was not needed. printed # twice)

            //then display the newly formatted phone number (NumberFormatted) to the user

            customerInfo.NumberFormatted = Console.ReadLine();
            Console.WriteLine(customerInfo.NumberFormatted);





            //call deposit

            account.Deposit(amountToDeposit);

            //retrieve balance

            Console.WriteLine($"Thank you your balance is now ${account.GetBalance()}.");
            
            


        }
    }
}
