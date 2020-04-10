using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedeDesignPattern
{
    class SecurityCodeChecker
    {
        private int _securityCode = 1234;

        public int GetSecurityCode()
        {
            return _securityCode;
        }

        public bool IsSecurityCodeCorrect(int securityCodeToCheck)
        {
            if (securityCodeToCheck == GetSecurityCode())
                return true;
            else
                return false;
        }
    }
}
