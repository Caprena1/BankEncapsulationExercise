using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank1 = new BankAccount();
           

            bank1.Deposit(2.5);
            var balance = bank1.GetBalance();
            Console.WriteLine(balance);

        }
    }
}
