namespace SOLID.Principles.OCP;

public class Program
{
    public static void Main(String[] args)
    {
        // Single Responsability Principle

        // Classes must be open for extension and closed for changes

        // var baseClass = new Message();
        // baseClass.Create("Base class: Message");

        /*
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

        FeedsMessage feed = new FeedsMessage();

        feed.Create(longMessage: "This is long message!");
    }
}