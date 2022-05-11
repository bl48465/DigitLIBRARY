using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class SalaryAccount : Account
    {
        public SalaryAccount(string name, string lastname) : base(name, lastname)
        {
        }

        public List<Transaction> GetSalaryTransactions(Account account,List<Transaction> transactions) { 

            return transactions.FindAll(x => x.Note.Equals("Savings") && x.UserId.Equals(account.Id));
        }
    }


}
