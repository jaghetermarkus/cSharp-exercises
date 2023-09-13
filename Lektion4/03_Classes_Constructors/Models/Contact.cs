

namespace _03_Classes_Constructors.Models;

public class Contact
{

    // string? är ett alternativ för att ange att det är okej att det är null, det är valbart fält.
    // null! (null-ignore) betyder att det kommer vara ett värde när det anges.


    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
}

