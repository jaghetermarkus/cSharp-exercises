
using _05_Classes_Inheritance.Models;

namespace _05_Classes_Inheritance.Services;

public class CustomerServices
{

    private static List<Customer> customers = new List<Customer>;

    public static void CreatePrivateCustomer()
    {
        var customer = new PrivateCustomer();

        customer.Id = Guid.NewGuid();
        customer.Created = DateTime.Now;
        customer.Modified = DateTime.Now;

        Console.Write("Ange förnamn: ");
        customer.FirstName = Console.ReadLine() ?? "";

        Console.Write("Ange efternamn: ");
        customer.LastName = Console.ReadLine() ?? "";

        Console.Write("Ange mejladress: ");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny privatkund har lagts till i listan.");
        Console.ReadKey();
    }

    public static void CreateCompanyCustomer()
    {
        var customer = new CompanyCustomer();

        customer.Id = Guid.NewGuid();
        customer.Created = DateTime.Now;
        customer.Modified = DateTime.Now;

        Console.Write("Ange företagsnamn: ");
        customer.CompanyName = Console.ReadLine() ?? "";

        Console.Write("Ange mejladress: ");
        customer.Email = Console.ReadLine() ?? "";

        Console.Write("Ange telefonnummer: ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny privatkund har lagts till i listan.");
        Console.ReadKey();

    }

}