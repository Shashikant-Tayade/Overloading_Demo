using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class Payment_Processor
    {
        double balance = 20000;
        //Overload 1: internal balance transfer.
        public bool ProcessPayment(int accNo, double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"amount must be positive.");
            }
            if (amount > balance)
            {
                Console.WriteLine($"[REJECTED] Insufficient Balance in account : {accNo}");
                return false;
            }
            Console.WriteLine($"balance : {balance}");
            balance = balance - amount;

            Console.WriteLine($"{amount}: transferred to account : {accNo}. new balance : {balance}");
            return true;
        }
        //Overload 2: Credit card payment (different parameter types.
        public bool ProcessPayment(double amount, string cardNo, DateTime expiry_date)
        {
            if (cardNo.Length <= 0 || cardNo == "")
            {
                Console.WriteLine("[ERROR] Invalid Card Number format.");
                return false;
            }
            if (expiry_date < DateTime.Now)
            {
                Console.WriteLine("[ERROR] Card Expired.");
                return false;
            }
            if (amount > balance)
            {
                Console.WriteLine($"balance : {balance}");
                Console.WriteLine("Insufficient Balance. please enter smaller amount.");
                return false;
            }
            Console.WriteLine($"balance : {balance}");
            balance = balance - amount;
            Console.WriteLine($"{amount} is transferred from card : {cardNo}");
            Console.WriteLine($"Current Balance is {balance}");
            return true;
        }

        // Overload 3: Digital Wallet with Loyalty Logic
        public void ProcessPayment(double amount, string email, bool useLoyaltyPoints)
        {
            Console.WriteLine($"balance : {balance}");
            if (useLoyaltyPoints)
            {
                double discount = amount * 0.10;
                balance = balance - discount;
                Console.WriteLine($"[LOYALTY] Applying 10% discount ({discount}).");

            }
            Console.WriteLine($"[SUCCESS] Wallet payment for {email} processed.  final balance: {balance}");
        }
    }
}
