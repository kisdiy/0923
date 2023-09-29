using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0923
{
    class ATM
    {
        public bool WithdrawMoney(BankAccount bankAccount, double sum)
        {
            try
            {
                bankAccount.Withdraw(sum);
                Console.WriteLine("OK");
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool PutMoney(BankAccount bankAccount, double sum)
        {
            try
            {
                bankAccount.Deposit(sum);
                Console.WriteLine("OK");
                return true;
            }
            
            
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch(InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
