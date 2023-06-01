using InterfacesAndAbstractClass.Abstraction;

namespace InterfacesAndAbstractClass;

public class Program
{
	public static void Main(String[] args)
	{
		Square square = new Square();

		Console.WriteLine(square.Description());

        Console.WriteLine("Color:");
        square.Color = Console.ReadLine();

        Console.WriteLine("Side:");
        square.Side = Convert.ToDouble(Console.ReadLine());

        square.CalculateArea();
        square.CalculatePerimeter();

        Console.WriteLine($"Shape's color is {square.Color}.");
        Console.WriteLine($"Area is {square.Area}.");
        Console.WriteLine($"Perimeter is {square.Perimeter}.");
    }
}