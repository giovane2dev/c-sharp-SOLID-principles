namespace AnemicDomainModel.Domain.Entities;

public class Program
{    public static void Main(String[] args)
    {
        // named arguments

        var item = new Item(orderId: 1, itemId: 1, itemName: "Item example", itemPrice: 10);        

        Console.WriteLine(item.ItemName);
    }
}
