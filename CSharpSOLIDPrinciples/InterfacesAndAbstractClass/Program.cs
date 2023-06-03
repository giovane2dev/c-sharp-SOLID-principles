using InterfacesAndAbstractClass.Abstraction;
using InterfacesAndAbstractClass.Interfaces;
using InterfacesAndAbstractClass.Interfaces.DependencyInjection;

namespace InterfacesAndAbstractClass;

public class Program
{
	public static void Main(String[] args)
	{
        /*
		 * ABSTRACTION EXAMPLE
		
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
		 */

        // INTERFACE EXAMPLE

        // Demo demo = new Demo();

        // demo.Draw();

        // IControl control = new Demo();

        // control.Draw();

        // DEPENDENCY INJECTION

        RegisterOcurrences registerOcurrences = new RegisterOcurrences(new RegisterInConsole());

        registerOcurrences.Register("This is message for register in console!");

        var path = "D:\\Development\\learning\\c-sharp-solid-principles\\CSharpSOLIDPrinciples\\InterfacesAndAbstractClass\\Interfaces\\DependencyInjection";

        RegisterOcurrences _registerOcurrences = new RegisterOcurrences(new RegisterInFile($"{path}/text.txt"));

        _registerOcurrences.Register("Hellow World!");
    }
}