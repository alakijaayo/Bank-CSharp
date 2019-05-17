using System;
using System.Collections.Generic;

namespace src
{
    public class Table
    {
        public List<string> history = new List<string>();
        private double _balance;
        private string date = DateTime.Now.ToString("dd/MM/yyyy");

        public string Deposit(double money)
        {
            history.Add($"{date} || {money:F} || || {_balance += money:F}");
            return "Your money has been deposited!";
        }

        public string Withdraw(int money)
        {
            
        }

        public static void Main()
        {
            var test = new Table();
            var addDeposit = test.Deposit(100);
            var testDeposit = test.history[0];
            Console.WriteLine(testDeposit);
        }
    }
}