using System.Text;

namespace _01_DataLogging.Interfaces;

public interface IUser
{
    string Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    byte[] Password { get; }
}


/*
public class User : IUser
{
    public User(string password)
    {
        Password = Encoding.UTF8.GetBytes(password);
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] Password { get; private set; }
}
*/