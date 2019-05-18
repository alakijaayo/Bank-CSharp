using System;
using System.Collections;

namespace src
{
    public class Table
    {
        public ArrayList History = new ArrayList();
        private double _balance;
        private string Date = DateTime.Now.ToString("dd/MM/yyyy");
        

        public string Deposit(double money)
        {
            History.Add($"{Date} || {money:F} || || {_balance += money:F}");
            return "Your money has been deposited!";
        }

        public string Withdraw(int money)
        {
            History.Add($"{Date} || || {money:F} || {_balance -= money:F}");
            return "Your money has been withdrawn!";
        }
        
        public string Statement()
        {
            var displayStatement = "date || credit || debit || balance\n";
            var lineBreak = "\n";
            for (var i = 0; i < History.Count; i++)
            {
                History.Reverse();
                displayStatement += History[i];
                displayStatement += lineBreak;

            }

            return displayStatement;
        }
        
        public static void Main()
        {
            var test = new Table();
            Console.WriteLine(test.Deposit(100));
            test.Withdraw(50);
            test.Deposit(80);
            Console.WriteLine(test.Statement());
        }
    }
}