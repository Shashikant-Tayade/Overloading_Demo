using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class Payment_Processor
    {
        //Overload 1: internal balance transfer.
        public void ProcessPayment(int accNo, decimal amount)
        {
            Console.WriteLine($"Processing internal transfer of {amount} to account {accNo}");
        }
        //Overload 2: Credit card payment (different parameter types.
        public void ProcessPayment(decimal amount, string cardName, string expiryDate)
        {
            Console.WriteLine($"Processing credit card payment of {amount}. Card : {cardName}.");
        }
        // Overload 3: Digital Wallet (Different number of parameters.
        public void ProcessPayment(decimal amount, string email, bool loyaltyPoints)
        {
            string suffix = loyaltyPoints ? "with loyalty points" : "standard";
            Console.WriteLine($"Processing wallet payment for {email} {suffix}");
        }

    }
}
