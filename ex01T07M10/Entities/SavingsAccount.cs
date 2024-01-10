using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01T07M10.Entities
{
    sealed class SavingsAccount: Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount(int number, string holder, double balance, 
            double interestRate):base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;
        }

        public override string AccountData()
        {
            return base.AccountData() +
                $"\n\tAccount type: Savings account," +
                $"\n\tInterest rate: {InterestRate:f2}";
        }
    }
}
