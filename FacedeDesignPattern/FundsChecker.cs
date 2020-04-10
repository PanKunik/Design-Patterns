using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedeDesignPattern
{
    class FundsChecker
    {
        private double _balance = 100d;

        public double GetCurrentBalance()
        {
            return _balance;
        }

        private void IncreaseBalance(double amount)
        {
            _balance += amount;
        }

        private void DecreaseBalance(double amount)
        {
            _balance -= amount;
        }

        public bool HaveEnoughMoney(double amount)
        {
            if(amount > _balance)
            {
                Console.WriteLine("You dont have enough money to withdraw");
                Console.WriteLine("Your current balance: {0}\n", GetCurrentBalance());

                return false;
            }
            else
            {
                DecreaseBalance(amount);

                Console.WriteLine("You succesfully witdraw your money.");
                Console.WriteLine("Your current balance: {0}\n", GetCurrentBalance());
                return true;
            }
        }

        public void MakeDeposit(double cash)
        {
            IncreaseBalance(cash);
            Console.WriteLine("You successfully deposited your money.");
            Console.WriteLine("Your current balance: {0}\n", GetCurrentBalance());
        }
    }
}
