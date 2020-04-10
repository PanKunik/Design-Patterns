using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedeDesignPattern
{
    class BankAccountFacade
    {
        private int accountNumber;
        private int securityCode;

        private AccountNumberChecker accountNumberChecker;
        private SecurityCodeChecker securityCodeChecker;
        private FundsChecker fundsChecker;

        public BankAccountFacade(int newAccountNumber, int newSecurityCode)
        {
            accountNumber = newAccountNumber;
            securityCode = newSecurityCode;

            accountNumberChecker = new AccountNumberChecker();
            securityCodeChecker = new SecurityCodeChecker();
            fundsChecker = new FundsChecker();
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetSecurityCode()
        {
            return securityCode;
        }

        public void WithdrawCash(double amount)
        {
            if(accountNumberChecker.IsAccountNumberCorrect(GetAccountNumber())
                && securityCodeChecker.IsSecurityCodeCorrect(GetSecurityCode())
                && fundsChecker.HaveEnoughMoney(amount))
            {
                Console.WriteLine("Transaction Complete.\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed.\n");
            }
        }

        public void MakeDeposit(double amount)
        {
            if(accountNumberChecker.IsAccountNumberCorrect(GetAccountNumber())
                && securityCodeChecker.IsSecurityCodeCorrect(GetSecurityCode()))
            {
                fundsChecker.MakeDeposit(amount);
                Console.WriteLine("Transaction Complete.\n");
            }
            else
            {
                Console.WriteLine("Transaction Failed.\n");
            }
        }
    }
}
