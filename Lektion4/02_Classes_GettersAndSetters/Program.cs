
using System.Runtime.ConstrainedExecution;
using System.Text;
using _02_Classes_GettersAndSetters.Models;

var customer = new Customer();

// set - sätt ett värde
customer.FirstName = "Markus";
customer.LastName = "Karlsson";
//customer.FullName = "Vidar Ahlqvist"; //Kan ej ändra FullName eftersom "set" inte är aktiverat.

// get - hämta värdet
var firstName = customer.FirstName;



var user = new User();
user.FirstName = "Markus";
user.LastName = "Karlsson";
user.Email = " Markus.karlsson@domain.com";


//Vill förhindra att detta är möjligt   user.Password = "1234";
// Förhindras genom 'privat set' i User klassen

user.SetsecurePassword("NyttLösen456!");
//var password = user.Password.ToString();
var password = Encoding.UTF8.GetString(user.Password);
// user.Password = Encoding.UTF8.GetString(user.Password);


Console.WriteLine($"Password: {password}");
Console.ReadKey();



