namespace BankAccounts;

 public abstract class Account
{
    public Account(string name, string lastname)
    {
        this.Id = Guid.NewGuid().ToString();
        this.Name = name;
        this.LastName = lastname;
        this.Balance = 0;
    }
    public string Id { get; private set; }
    public string Name { get; set; }
    public string LastName { get; set; }

    private double Balance;

    public double GetCurrentBalance()
    {
        return this.Balance;
    }
    public void Withdraw(double amount)
    {
         this.Balance -= amount;
    }
    public void Deposit(double amount)
    {
        this.Balance += amount;
    }
}
