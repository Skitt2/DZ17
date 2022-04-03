using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета ");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счета ");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО ");
            string name = Console.ReadLine();
            BankAccount<int> bankAccount1 = new BankAccount<int>(numInt, balance, name);
            Console.WriteLine(bankAccount1.GetInfo());

            Console.WriteLine("Введите строковый номер счета ");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите баланс счета ");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО ");
            name = Console.ReadLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>(numString, balance, name);
            Console.WriteLine(bankAccount2.GetInfo());

            Console.ReadKey();
        }
    }
}
