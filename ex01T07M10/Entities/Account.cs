using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01T07M10.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public virtual string AccountData()
        {
            return $"\n\nAccount Data: " +
                $"\n\tDate: {DateTime.Now.ToLongDateString()}," +
                $"\n\tNumber account: {Number}," +
                $"\n\tHolder account: {Holder}," +
                $"\n\tBalance account: {Balance:f2}";
        }
    }
}
