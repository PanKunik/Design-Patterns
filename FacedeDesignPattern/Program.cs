using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade bankAccountFacade = new BankAccountFacade(12345678, 1234);

            bankAccountFacade.WithdrawCash(50d);

            bankAccountFacade.WithdrawCash(900d);

            bankAccountFacade.MakeDeposit(200d);

            bankAccountFacade.WithdrawCash(100d);

            Console.Read();
        }
    }
}
