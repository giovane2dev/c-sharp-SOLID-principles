namespace DependencyInjection;

class Program
{
    public static void Main(String[] args)
    {
        Pharmacy pharmacy = new Pharmacy(new Product());

        pharmacy.AddNewPharmacyProduct("teste");
    }
} 