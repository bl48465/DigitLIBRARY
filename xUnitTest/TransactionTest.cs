using BankAccounts;
using System;
using Xunit;

namespace xUnitTest
{
    public class TransactionTest
    {


        [Fact]
        public void Deposit()
        {
            //ARRANGE 

            var salaryAccount = new SalaryAccount("Filan", "Fisteku");

            //ACT
            Transaction.DepositMoney(salaryAccount, 382, "Salary");

            //ASSERT

            Assert.Equal(382, salaryAccount.GetCurrentBalance());
        }

        [Fact]
        public void Withdraw()
        {
            //ARRANGE 

            var salaryAccount = new SalaryAccount("Filan", "Fisteku");
            Transaction.DepositMoney(salaryAccount, 382, "Salary");

            //ACT
            Transaction.WithdrawMoney(salaryAccount, 360, "Salary");

            //ASSERT

            Assert.Equal(22, salaryAccount.GetCurrentBalance());
        }


        [Fact]
        public void TestNegativeAmountForDeposit()
        {
            //ARRANGE 

            var salaryAccount = new SalaryAccount("Filan", "Fisteku");

            //ACT + ASSERT
            Assert.Throws<Exception>(() => Transaction.DepositMoney(salaryAccount, 0, "Salary"));
        }

        [Fact]
        public void TestNegativeAmountForWithdrawal()
        {
            //ARRANGE 

            var salaryAccount = new SalaryAccount("Filan", "Fisteku");
            Transaction.DepositMoney(salaryAccount, 382, "Salary");

            //ACT + ASSERT
            Assert.Throws<Exception>(() => Transaction.WithdrawMoney(salaryAccount, -4, "Salary"));
        }

        [Fact]
        public void TestNegativeBalance()
        {
            //ARRANGE 

            var salaryAccount = new SalaryAccount("Filan", "Fisteku");
            Transaction.DepositMoney(salaryAccount, 382, "Salary");
           
            //ACT

            var balance = salaryAccount.GetCurrentBalance();


            //ASSERT

            Assert.True(balance>0);
        }
    }
   
}