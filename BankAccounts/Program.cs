using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts;

 class Program
{
    static void Main(string[] args)
    {
        var account = new Account("Filan", "Fisteku");
       

        Transaction trs = Transaction.DepositMoney(account,500);
        Transaction trs2 = Transaction.WithdrawMoney(account,200);


        Console.WriteLine(trs.ToString());
        Console.WriteLine(trs2.ToString());

        Console.WriteLine(account.GetCurrentBalance());

        Transaction.DepositMoney(account,200);
        Console.WriteLine("Balance after last transaction " + account.GetCurrentBalance());





    }
}
   