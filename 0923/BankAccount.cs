using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0923
{
    class BankAccount
    {
        private double balance;

        public double GetBalance()
        {
            return balance;
        }

        public BankAccount()
        {
            balance = 0;
        }
        public void Deposit(double sum)
        {
            if (sum <= 0)
                throw new ArgumentException("Вы ввели сумму меньше 0");
            balance += sum;
        }

        public void Withdraw(double sum)
        {
            if (sum <= 0)
                throw new ArgumentException("Вы ввели сумму меньше 0");
            if (sum > balance)
                throw new InsufficientFundsException("Введеная сумма превышает баланс на счету. Повторите попытку");
            balance -= sum;
        }
    }
}
