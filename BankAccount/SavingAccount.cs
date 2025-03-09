using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string owner, decimal interestRate) : base(owner + " (" + interestRate + "%)")
        {
            InterestRate = interestRate;
        }
        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not depost $ " + amount;

            }
            if (amount > 220000)
            {
                return "AML Deposit Limit Reached."; // Anti-Money Laundering
            }
            decimal InterestAmount = (InterestRate / 100) * amount;
            Balance += amount + InterestAmount;
            return "Deposit Complated succsesfully.";
        }
    }
}
