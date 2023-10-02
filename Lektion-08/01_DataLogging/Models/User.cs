using _01_DataLogging.Interfaces;

namespace _01_DataLogging.Models;

public class User : IUser
{
    public string Id { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    public byte[] Password { get; set; } = null!;


    public void GenerateSecurePassword(string password)
    {

    }

}

