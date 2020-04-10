using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedeDesignPattern
{
    class AccountNumberChecker
    {
        private int _accountNumber = 12345678;

        public int GetAccountNumber()
        {
            return _accountNumber;
        }

        public bool IsAccountNumberCorrect(int accountNumberToCheck)
        {
            if (accountNumberToCheck == GetAccountNumber())
                return true;
            else
                return false;
        }
    }
}
