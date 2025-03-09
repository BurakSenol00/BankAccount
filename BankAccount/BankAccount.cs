using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        
        public virtual string Deposit(decimal amount)
        {
            if(amount<=0)
            {
                return  "You can not depost $ " + amount;
            }
            if(amount>22000)
            {
                return "AML Deposit Limit Reached.";
            }
            Balance += amount;
            return "Deposit Complated succsesfully.";
        }
        public string Withrow(decimal amount)
        {
            if (amount <= 0)
            {
                return "You can not withrow $ " + amount;

            }
            if (amount > Balance)
            {
                return "You dont have enough money!";
            }
            Balance -= amount;
            return "Withrow  Complated succsesfully.";
        }

    }
}
