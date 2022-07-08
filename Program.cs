using System;

namespace Banking {

    class Program {
        
        static void Main(string[] args) {
            Account newAccount = new Account();

            try {
                newAccount.MakeDeposit(100);
                Console.WriteLine(newAccount.DisplayBalance());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try {
                newAccount.makeWithdrawal(50);
                Console.WriteLine(newAccount.DisplayBalance());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try {
                newAccount.makeWithdrawal(51);
                Console.WriteLine(newAccount.DisplayBalance());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try {
                newAccount.makeWithdrawal(-50);
                Console.WriteLine(newAccount.DisplayBalance());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}