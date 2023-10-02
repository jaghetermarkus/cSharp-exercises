using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Models;

namespace _01_Assignment_Example.Services;

public static class MenuService
{

    private static readonly ICustomerService customerService = new CustomerService();

    public static void MainMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("[1] Skapa ny kund");
            Console.WriteLine("[2] Visa alla kunder");
            Console.WriteLine("[3] Visa en kund");
            Console.WriteLine("[4] Ta bort en kund");
            Console.WriteLine("[0] Avsluta");
            Console.WriteLine("");
            Console.Write("Välj något av följande alternativ: ");
            var option = Console.ReadLine();

            Console.Clear();
            switch (option)
            {
                case "1":
                    AddCustomerMenu();
                    break;

                case "2":
                    ViewAllCustomersMenu();
                    break;

                case "3":
                    ViewOneCustomerMenu();
                    break;

                case "4":
                    RemoveOneCustomerMenu();
                    break;

                case "0":
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("Tryck valfri knapp för att gå tillbaka...");
            Console.ReadKey();

        } while (true);
    }

    public static void AddCustomerMenu()
    {
        // ADD CUSTOMER
        Console.WriteLine("LÄGG TILL NY KUND");
        ICustomer customer = new Customer();

        Console.Write("Förnamn: ");
        customer.FirstName = Console.ReadLine();
        Console.Write("Efternamn: ");
        customer.LastName = Console.ReadLine();
        Console.Write("E-post: ");
        customer.Email = Console.ReadLine();

        customer.Address = new Address();
        Console.Write("Gatuadress: ");
        customer.Address.StreetName = Console.ReadLine();
        Console.Write("Gatunummer: ");
        customer.Address.StreetNumber = Console.ReadLine();
        Console.Write("Postnummer: ");
        customer.Address.PostalCode = Console.ReadLine();
        Console.Write("Stad: ");
        customer.Address.City = Console.ReadLine();

        Task.Run(() => customerService.AddCustomerAsync(customer));
        Console.WriteLine("Ny kund har lagts till");
    }

    public static void ViewAllCustomersMenu()
    {
        Console.WriteLine("HELA LISTAN:");
        //var customers = customerService.GetAllCustomers();
        foreach (var customer in customerService.GetAllCustomers())
        {
            Console.WriteLine(customer.FullName);
            Console.WriteLine(customer.Address?.FullAddress);
            Console.WriteLine();
        }
    }

    public static void ViewOneCustomerMenu()
    {
        Console.WriteLine("VISA EN KUND");
        Console.WriteLine("Sök efter unik e-post: ");
        var email = Console.ReadLine();

        var customer = customerService.GetOneCustomer(email!);

        Console.WriteLine(customer?.FullName);
        Console.WriteLine(customer?.Address?.FullAddress);
        Console.WriteLine(customer?.Email);
        Console.WriteLine();
    }

    public static void RemoveOneCustomerMenu()
    {
        Console.WriteLine("TA BORT EN KUND");
        Console.WriteLine("Ange unik e-post: ");
        var email = Console.ReadLine();

        customerService.RemoveCustomer(email!);
    }

}

