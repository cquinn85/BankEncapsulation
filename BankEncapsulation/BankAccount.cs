using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BankEncapsulation
{
    class BankAccount
    {
        public BankAccount()
        { 
        }

        //In your BankAccount class, create the following:
        //A private field of type double named balance with a value of 0

        private double balance = 0; //balance is what we are trying to hide or encapsulate

        //Define a method named Deposit that will accept a double 
        //and store that value in the balance field

        //this is the encapsulation below
        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a method named GetBalance 
        //that will return the amount stored in the balance field 

        public double GetBalance()
        {
            return balance;
        }

        //In the main method of your application, 
        //create a new instance of the BankAccount class. 
        //Allow the user of the application to Deposit money
        //and retrieve their balance through the console.

    }
}
