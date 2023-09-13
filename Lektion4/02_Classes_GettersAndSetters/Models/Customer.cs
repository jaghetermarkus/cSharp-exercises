namespace _02_Classes_GettersAndSetters.Models;

public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}"; // Den är "kalkulerad".

    //Skillnaden mellan att lägga till get/set mot att inte ha med det alls, man kan fortfarande lägga till/ ta bort, men det finns ingen logik! Ex. kan du inte använda .Trim för att snygga till en string om du inte har använt get/set när du deklarerat variabeln. 

    private string name1 = "Vilgot";

    public string MittNamn
    {
        get { return name1;  }
        set { name1 = value.Trim; }
    }


}

