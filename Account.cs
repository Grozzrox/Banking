
namespace Banking {

    class Account 
    {
        protected double balance;
        private List<Transaction> transactions = new List<Transaction>();

        private int accountNumber;
        private string owner;

        public string DisplayBalance() {
            
            string balanceString = balance.ToString();
            return balanceString;
        }

        public void MakeDeposit(double amount, string note = "") {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            } 
            else 
            {
                balance += amount;

                var deposit = new Transaction(amount, DateTime.Now, note);
                transactions.Add(deposit);
            }
        }

        public void makeWithdrawal(double amount, string note = "") {

            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be greater than zero");
            }
            else if (balance - amount < 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient funds");
            }
            else 
            {
                balance -= amount;
                var withdrawal = new Transaction(amount, DateTime.Now, note);
                transactions.Add(withdrawal);
            }
            
        }

        public string getAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\t\tAmount\t\tNote");

            foreach(var item in transactions)
            {
                report.AppendLine($"{item.date.ToShortDateString()}\t{item.amount}\t{item.note}");
            }
            return report.ToString();
        }
    }
}