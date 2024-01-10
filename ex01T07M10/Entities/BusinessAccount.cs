using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01T07M10.Entities
{
    class BusinessAccount: Account
    {
        public double LoanLimit { get; private set; }

        public BusinessAccount(int number, string holder, double balance, 
            double loanLimit): base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount < LoanLimit)
                Balance += amount;
        }

        public override string AccountData()
        {
            return base.AccountData() +
                $"\n\tAccount type: Business, " +
                $"\n\tLoan Limit: {LoanLimit:f2} ";
        }
    }
}
