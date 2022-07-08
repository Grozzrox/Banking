namespace Banking {

    class SavingsAccount : Account // the " : Account" means we are EXTENDING the Account class.
    {
        private double interestRate;

        public void ApplyInterest()
        {
            double payment = this.balance * this.interestRate;
            this.MakeDeposit(payment);
        }

    }
}
