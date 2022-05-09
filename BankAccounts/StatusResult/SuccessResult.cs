namespace BankAccounts;

public class SuccessResult : StatusResult
{
    public SuccessResult(string message, int code) : base(message, code)
    {
        this.message = message;
        this.code = 200;
    }
}
