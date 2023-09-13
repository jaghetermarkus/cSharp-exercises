
using _04_Classes_Example_With_List.Models;

var customers = new List<Customer>();

var userInput = "n";

do
{
    var customer = new Customer();
    Console.WriteLine("Namn: ");
    customer.FirstName = Console.ReadLine() ?? "";

    Console.WriteLine("Email: ");
    customer.Email = Console.ReadLine() ?? null!;

    Console.WriteLine("Phone: ");
    customer.PhoneNumber = Console.ReadLine();

    customers.Add(customer);

    Console.WriteLine("Vill du lägga in en till kontakt (y/n): ");
    userInput = Console.ReadLine();

} while (userInput!.ToLower() == "y");

