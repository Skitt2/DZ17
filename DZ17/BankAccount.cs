using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ17
{
    class BankAccount <T>
    {
        public T Num { get; set; }
        public double Balance { get; set; }
        public string Name { get; set; }

        public BankAccount(T num, double balance, string name)
        {
            Num = num;
            Name = name;
            Balance = balance;
        }

        public string GetInfo()
        {
            return $"{Num} {Balance} {Name}";
        }
    }
}
