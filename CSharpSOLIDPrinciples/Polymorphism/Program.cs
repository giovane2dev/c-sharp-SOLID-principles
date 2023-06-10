using System.Security.Cryptography.X509Certificates;

namespace Polymorphism;

public class Program
{
	public static void Main(String[] args)
	{
		var pictures = new List<Picture>
		{
			new Circle(),
			new Square(),
			new Triangle(),
		};

		foreach (var picture in pictures)
		{
            picture.Draw();
        }

		Square square = new Square();

		square.Draw("This is new Draw method!");
	}
}