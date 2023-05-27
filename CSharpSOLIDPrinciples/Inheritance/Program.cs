// namespace Inheritance;
namespace Inheritance.UpCastingAndDownCasting;

public class Program
{
    public static void Main(String[] args)
    {
        /*
         // instanciates child class and transfer parameter to base class
         SavingsAccount savingsAccount = new SavingsAccount("New text");

         // call the child method that replaced the parent method
         savingsAccount.CreateBalance();
         */


        /*
         * UPCASTING EXAMPLE
         
         SavingsAccount savingsAccount = new SavingsAccount();

         Account a = savingsAccount;

         Console.WriteLine(a == savingsAccount);

         a.Calc(); 
         */


        /*
         * DOWNCASTING EXAMPLE

         SavingsAccount savingsAccount = new SavingsAccount();

         Account a = savingsAccount; // implied

         SavingsAccount s = (SavingsAccount)a; // explicit

         Console.WriteLine(s == a);

         s.Calc();
         s.GetCalc();
         */

        Console.WriteLine("Last commit: Changes the relationship from inheritance to finalization");
    }
}