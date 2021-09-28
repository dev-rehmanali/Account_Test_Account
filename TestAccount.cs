using System;
using Task3._2;

namespace Task2._2
{
    class TestAccount
    {
        static void Main(string[] args)
        {

            Account account = new Account("AC-B01",85000);

            account.Deposit(5000);

            account.Withdraw(25000);

            account.Print();
        }
    }
}
