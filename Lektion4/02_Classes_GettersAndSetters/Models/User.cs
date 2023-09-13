using System.Security.Cryptography;
using System.Text;


namespace _02_Classes_GettersAndSetters.Models;

public class User
{
    private string _email;

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get => _email; set => _email = value.Trim().ToLower(); } // trimmar bort mellanslag samt ändrar till små bokstäver för att det ska se snyggare ut.

    public byte[] Password { get; private set; }
    public byte[] SecurityKey { get; private set; }


    public void SetsecurePassword(string password)
    {
        using var hmac = new HMACSHA512();
        SecurityKey = hmac.Key;
        Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

}

