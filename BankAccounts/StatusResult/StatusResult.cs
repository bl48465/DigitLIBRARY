namespace BankAccounts;

public class StatusResult
{
    public string message;
    public int code;
    public StatusResult(string message,int code)
    {
        this.message = message;
        this.code = code;
    }
    public string toString()
    {
        return this.message + " " + this.code;
    }
}
