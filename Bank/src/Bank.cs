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
             InitialBalance += add;
             return InitialBalance;
         }

         public int Withdraw(int remove)
         {
             
         }
    }
}