using SOLID.Principles.LSP.Violation.Example1;
using SOLID.Principles.LSP.Violation.Example2;

namespace SOLID.Principles.OCP;

public class Program
{
    public static void Main(String[] args)
    {
        // Single Responsability Principle
        
        /*
        // Classes must be open for extension and closed for changes

        // var baseClass = new Message();
        // baseClass.Create("Base class: Message");
        
        var derivedClass = new FeedsMessage(String.Empty);

        string longMessage = """
            This is a long message.
            It has several lines.
                Some are indented
                        more than others.
            Some should start at the first column.
            Some have "quoted text" in them.
            """;

        derivedClass.Create(longMessage);
        */

        // Open-Closed Principle

        /*
        FeedsMessage feed = new FeedsMessage();

        feed.Create(longMessage: "This is long message!");
        */

        // Liskov Substitution Principle

        /*
        Employee employee1 = new Manager("Giovane", "Cargo");
        Employee employee2 = new Seller("Pessoa", "Cargo");

        // Console.WriteLine(employee1.GetType());
        // Console.WriteLine(employee2.GetType());

        var salary = employee1.CalculateSalary(10000);

        Console.WriteLine(salary);
        
        var numbers = new int[] { 10, 15, 20, 25};

        Calculate calculateSum1 = new CalculateSum(numbers);
        Calculate calculateSum2 = new CalculateSumEvenNumbers(numbers);

        Console.WriteLine($"The sum of numbers is {calculateSum1.Calc()}!");
        Console.WriteLine($"The sum of even numbers is {calculateSum2.Calc()}!");
        */

        // Interface Segregation Principle
    }
}