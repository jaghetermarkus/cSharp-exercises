namespace _05_Classes_Inheritance.Models;

public class CompanyCustomer : Customer
{

    // ": Customer" betyder att denna klassen ärver från Customer-klassen och får de properties som den också har.

    public string CompanyName { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;

}

