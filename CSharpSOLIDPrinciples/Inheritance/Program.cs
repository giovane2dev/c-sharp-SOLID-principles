namespace Inheritance;

public class Program
{
    public static void Main(String[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount("New text");

        savingsAccount.CreateBalance();
    }
}