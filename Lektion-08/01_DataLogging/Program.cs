/*  EXIMINATIONSUPPGIFT GRUNDER

    C - Lägg till något i en lista
    R - Kunna se hela listan
    R - Se något specifikt från listan
    U - Uppdatera något specifikt från listan
    D - Ta bort något specifik från listan

    Create
    Read
    Read
    Update
    Delete

    Medlemslista
    Kundlista
    Todolista
    Medlemsregister
    Användarlista

    Ordersystem
        - lägg en order
        - hämta alla ordrar
        - hämta en specifik order
        - uppdatera en order
        - ta bort en order

    Fakturasystem osv osv...
    
 */

using System.Text;
using _01_DataLogging.Interfaces;

IUser user = new User("BytMig123!");
Console.WriteLine(user.Password);
Console.ReadKey();
//user.Password = Encoding.UTF8.GetBytes();