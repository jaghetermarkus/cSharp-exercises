

/* Json = JavaScript Object Notation

    "key": "value"

    {
        "firstName": "Markus",
        "lastName": "Karlsson",
        "age": 34,
        "isActive": false,
        "skills": ["C#", "JS", "Python", "C"],
        "relatives": [
            { "firstName": "Markus", "lastName": "Karlsson" },
            { "firstName": "Vidar", "lastName": "Ahlqvist" }
        ]
    }
 
 */

using _01_SaveAndRead.Models;
using _01_SaveAndRead.Services;
using Newtonsoft.Json;

var userService = new UserService();
userService.GetUsers();
//FileService.ReadFromFile() = JsonConvert.DeserializeObject(_users);

var user = new User
{
    firstName = "Tomas",
    lastName = "Karlsson",
    Email = "Markus@domain.com"
};



userService.AddUser(user);

Console.ReadKey();
