using System;

namespace src
{
    public class Bank
    {
         int InitialBalance = 0;

         public int MyBalance()
         {
             return InitialBalance;
         }

         public int Deposit(int add)
         {
             if (add <= 0)
             {
                 throw new System.ArgumentException("Please Input Correct Amount To deposit!");
             }
             
             InitialBalance += add;
             return InitialBalance;
         }

         public int Withdraw(int remove)
         {
             if (remove <= 0)
             {
                 throw new System.ArgumentException("Please Input Correct Amount To Withdraw!");
             }

             if (remove > InitialBalance)
             {
                 throw new System.ArgumentException("Not Enough Funds Available. Please Put In Amount You Wish To Withdraw!");
             }
             InitialBalance -= remove;
             return InitialBalance;
         }
    }
}