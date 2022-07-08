using System;

namespace Banking {

    class Account 
    {
        protected double balance;

        private int accountNumber;
        private string owner;

        public string DisplayBalance() {
            
            string balanceString = balance.ToString();
            return balanceString;
        }

        public void MakeDeposit(double amount) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            } 
            else 
            {
                balance += amount;
            }
        }

        public void makeWithdrawal(double amount) {

            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            }
            else if (balance - amount < 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient funds");
            }
            else 
            {
                balance -= amount;
            }
            
        }
    }
}