namespace BankAccounts;

public class Transaction
{
    public string Id { get; set; }
    public double Amount { get; }
    public string Note { get; set; }
    public DateTime CreatedAt { get; }
    public string UserId { get; set; }

    public Transaction(double amount,string note)
    {
        this.Id = Guid.NewGuid().ToString();
        this.Amount = amount;
        this.Note = note;
        this.CreatedAt = DateTime.Now;
    }

    private static StatusResult WithdrawValidator(Account account, double amount)
    {
        if (amount > account.GetCurrentBalance())
        {
            return new ErrorResult("You have sufficient balance!", 400);
        }
        if (amount <= 0)
        {
            return new ErrorResult($"You can't withdraw {amount} $ !", 400);
        }
        else
        {
            return new SuccessResult("Withdraw Successful", 200);
        }
    }

    private static StatusResult DepositMoneyValidator(double amount)
    {
        if (amount <= 0)
        {
            return new ErrorResult($"You can't deposit {amount} $ !", 400);

        }
        return new SuccessResult($"You have deposited {amount} $ succesfully!", 200);
    }

    public static Transaction DepositMoney(Account account, double amount,string note)
    {
        if (DepositMoneyValidator(amount) is SuccessResult)
        {
            account.Deposit(amount);
            return new Transaction(amount, note) { UserId = account.Id };
        }
        else
        {
            throw new Exception("Something went wrong!");
        }
    }
    public static Transaction WithdrawMoney(Account account,double amount,string note)
    {
        if (WithdrawValidator(account,amount) is SuccessResult)
        {
            account.Withdraw(amount);
            return new Transaction(amount, note) { UserId = account.Id };
        }
        else
        {
            throw new Exception("Something went wrong!");
        }
    }

    public string ToString()
    {
        return this.Id + " - " + this.Amount + " - at time -> " + this.CreatedAt;
    }



}
