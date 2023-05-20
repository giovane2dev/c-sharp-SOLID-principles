namespace SOLID.Principles.OCP;

public class Program
{
public static void Main(String[] args)
    {
        // Open-Closed Principle

        // Classes must be open for extension and closed for changes

        var baseClass = new Message();

        var derivedClass = new FeedsMessage(String.Empty);

        // baseClass.Create("Base class: Message");

        string longMessage = """
            This is a long message.
            It has several lines.
                Some are indented
                        more than others.
            Some should start at the first column.
            Some have "quoted text" in them.
            """;

        derivedClass.Create(longMessage);
    }
}