namespace BankAccounts;

public class ErrorResult : StatusResult
{
    public ErrorResult(string message, int code) : base(message, code)
    {
        this.message = message;
        this.code = 400;
    }
}
