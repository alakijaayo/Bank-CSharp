using System;

namespace src
{
    public class Bank
    {
        private double _initialBalance;
        public Table NewTable = new Table();

         public double MyBalance()
         {
             return _initialBalance;
         }

         public string Deposit(double add)
         {
             if (add <= 0)
             {
                 throw new ArgumentException("Please Input Correct Amount To deposit!");
             }
             
             _initialBalance += add;
             return NewTable.Deposit(add);
         }

         public string Withdraw(double remove)
         {
             if (remove <= 0)
             {
                 throw new ArgumentException("Please Input Correct Amount To Withdraw!");
             }

             if (remove > _initialBalance)
             {
                 throw new ArgumentException("Not Enough Funds Available. Please Put In Amount You Wish To Withdraw!");
             }
             _initialBalance -= remove;
             return NewTable.Withdraw(remove);
         }

         public string DisplayStatement()
         {
             return NewTable.Statement();
         }
    }
}