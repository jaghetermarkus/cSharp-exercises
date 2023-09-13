
using _03_Classes_Constructors.Models;

/*
*/

var customer_1 = new Customer();
customer_1.Name = "Markus";
customer_1.Email = "Markus@domain.com";
customer_1.PhoneNumber = "90510";


var customer_2 = new Customer
{
    Id = 1,
    Name = "Vidar",
    Email = "Karlsson@domain.com",
    PhoneNumber = "070-1234567"
};


var customer_3 = new Customer("Vilgot", "Vilgot@domain.com", "070-9876543");

