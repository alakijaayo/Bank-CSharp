using System;

namespace src
{
    public class Bank
    {
        private double _initialBalance;

         public double MyBalance()
         {
             return _initialBalance;
         }

         public double Deposit(int add)
         {
             if (add <= 0)
             {
                 throw new ArgumentException("Please Input Correct Amount To deposit!");
             }
             
             _initialBalance += add;
             return _initialBalance;
         }

         public double Withdraw(double remove)
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
             return _initialBalance;
         }
    }
}