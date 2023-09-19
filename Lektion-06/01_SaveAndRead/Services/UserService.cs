using _01_SaveAndRead.Models;
using Newtonsoft.Json;

namespace _01_SaveAndRead.Services;

public class UserService
{
    private List<User> _users = new List<User>();

    public void AddUser(User user)
    {
        _users.Add(user);

        FileService.SaveToFile(JsonConvert.SerializeObject(_users));

        // var json = JsonConvert.SerializeObject(_users);
        // FileService.SaveToFile(json);

    }

    public void GetUsers()
    {
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _users = JsonConvert.DeserializeObject<List<User>>(content)!;


        foreach (var user in _users)
        {
            Console.WriteLine($"{user.firstName} {user.lastName} {user.Email}");
        }
    }

}

