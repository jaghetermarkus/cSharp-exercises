
/* LISTS
-------------------
En lista är en dynamisk lista som gör att det går att lägga till och ta bort objekt i från listan. Det går även att sortera om den. Det finns lite olika typer av listor för olika ändamål.


Instansiera en ny lista:
--------------------
List<int> list = new List<int>();
var list = new List<string>();
List<string> list = new();

List                ReadWrite       Lägga till, ta bort, sortera
IEnumerable<>       Read            Sortera     (Bra vid databaslistor, för att det itne ska gå att ändra tills det presenteras i frontend)
ICollection         ReadWrite       Lägga till, ta bort, sortera


* I = Betyder Interface och har då en uppsättning av funktioner vi kan komma åt och göra några med.

List<string> list_1 = new List<string>();
list_1.Add("1");
list_1.Remove("1");
list_1.OrderByDescending(x => x);
list_1.Clear();
list_1.FirstOrDefault();
list_1.LastOrDefault();
list_1.Insert(0, "1");

IEnumerable<string> list_2 = new List<string>();
list_2.Add("1");
list_2.Remove("1");
list_2.OrderByDescending(x => x);
list_2.Clear();
list_2.FirstOrDefault();
list_2.LastOrDefault();
list_2.Insert(0, "1");


ICollection<string> list_3 = new List<string>();
list_3.Add("1");
list_3.Remove("1");
list_3.OrderByDescending(x => x);
list_3.Clear();
list_3.FirstOrDefault();
list_3.LastOrDefault();
list_3.Insert(0, "1");

using System.Collections.ObjectModel;
/// Ej fokus just nu då vi inte kommer använda detta mycket
ObservableCollection<string> list_4 = new List<string>();
list_4.Add("1");
list_4.Remove("1");
list_4.OrderByDescending(x => x);
list_4.Clear();
list_4.FirstOrDefault();
list_4.LastOrDefault();
list_4.Insert(0, "1");





var names = new List<string>();

names.Add("Markus");
names.Add("Vidar");
names.Add("Vilgot");

foreach (var name in names)
{
    Console.WriteLine(name);
    //Behövs en {} om man bara har en rad som ska skrivas
}

Console.WriteLine();
var user = names.FirstOrDefault(name => name.ToLower() == "vidar");
if (user != null)
{
Console.WriteLine(user);
}
else
{
    Console.WriteLine("Användaren hittades inte.");
}

*/


/*  CLASSES
--------------------------
Klasser är en del av objektorienterad programmering.
En klass är alltså ett objekt och en klass kan innehålla flera olika saker.
Se en klass som en mall över hur något ser ut eller hur något är.

En användare, en kund, en order, en produkt, en prislista, en adress..... ja det kan vara vad som helst i systemet. 

*/




using _04_ClassesAndLists.Models;

var contactPersons = new List<ContactPerson>();
var answer = "n";

do
{
    // Skapar ny kontaktperson
    var contactPerson = new ContactPerson();

    Console.Write("First name: ");
    contactPerson.FirstName = Console.ReadLine() ?? "";

    Console.Write("Last name: ");
    contactPerson.LastName = Console.ReadLine() ?? "";

    Console.Write("Email: ");
    contactPerson.Email = Console.ReadLine() ?? "";

    Console.Write("Phone number: ");
    contactPerson.PhoneNumber  = Console.ReadLine() ?? "";

    // Lägg till kontaktperson i listan
    contactPersons.Add(contactPerson);

    Console.Write("Vill du lägga till en till person? (y/n): ");
    answer = Console.ReadLine();

} while (answer!.ToLower() == "y");

Console.WriteLine("Här är alla kontaktpersoner");
foreach (var contact in contactPersons)
{
    Console.WriteLine($"{contact.FirstName} {contact.LastName} {contact.Email} {contact.PhoneNumber}");
}

Console.ReadKey();


// Försök göra ett litet program 



