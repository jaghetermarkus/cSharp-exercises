


/* ABSTRACT CLASS - Klassen Customer() är skyddad eftersom den har 'abstract' i klass-deifinitionen

var privateCustomer = new Customer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "mejl@domain.com",
};


var privateCustomer = new PrivateCustomer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "mejl@domain.com",

    FirstName = "Markus",
    LastName = "Karlsson",
    PhoneNumber = "90510"
};

var companyCustomer = new CompanyCustomer()
{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "bosse@domain.com",

    CompanyName = "Bosses EL",
    PhoneNumber = "08-123456"
};

*/

using _05_Classes_Inheritance.Services;

var runAgain = false;

do
{

Console.Clear();
Console.WriteLine("Vad för typ av kund vill du skapa (p = privat, f = företag): ");
var userInput = Console.ReadLine();

    switch (userInput?.ToLower())
    {
        case "p":
            CustomerServices.CreatePrivateCustomer();
            break;

        case "f":
            CustomerServices.CreateCompanyCustomer();
            break;

        default:
            break;
    }

    Console.WriteLine("Vill du fortsätta? (y/n): ");
    runAgain = (Console.ReadLine()!.ToLower() == "j") ? true : false;

} while (runAgain);




//Console.WriteLine(customer.Id);
//Console.WriteLine("Created: " + customer.Created);
//Console.WriteLine("Modified:" + customer.Modified);


Console.ReadKey();
