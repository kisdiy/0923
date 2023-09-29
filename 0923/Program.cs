using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Cоздать простой прототип банкомата, который будет взаимодействовать с банковским счетом через классы BankAccount и ATM.
Программа должна обеспечивать следующий функционал: 1. Создание банковского счета с начальным балансом. 
2. Возможность вносить средства на банковский счет через метод Deposit класса BankAccount. 
3. Возможность снимать средства с банковского счета через метод Withdraw класса BankAccount.
4. Обработку ошибок: • Попытка снять/внести отрицательную сумму должна вызывать ArgumentException с соответствующим сообщением.
• Попытка снять сумму, превышающую баланс, должна вызывать InsufficientFundsException с сообщением о недостаточности средств. 
5. Класс ATM должен предоставлять метод WithdrawMoney, который будет использовать класс BankAccount для снятия средств и обрабатывать исключения.
6. В основной программе (Main) создайте банковский счет, выводите текущий баланс, а затем выполняйте операции снятия и выводите результаты операций и обработанные ошибки.
7. Протестируйте программу на различных сценариях, включая правильные и ошибочные операции.

 */
namespace _0923
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();

            Console.WriteLine(bankAccount.GetBalance());

            ATM aTM = new ATM();

            double sum;
            do
            {
                Console.WriteLine("Введите сумму, которую хотите внести");
                sum = double.Parse(Console.ReadLine());
            }
            while (!aTM.PutMoney(bankAccount, sum));
            Console.WriteLine(bankAccount.GetBalance());
            do
            {
                Console.WriteLine("Введите сумму, которую хотите снять");
                sum = double.Parse(Console.ReadLine());
            }
            while (!aTM.WithdrawMoney(bankAccount, sum));
            Console.WriteLine(bankAccount.GetBalance());
            Console.ReadLine();
        }
    }
}
