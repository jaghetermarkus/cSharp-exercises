using _01_Exercise.Interfaces;
using _01_Exercise.Models;

namespace _01_Exercise.Services;

internal interface IMenuService
{
    public void MainMenu();
    public void CreateMenu();
    public void ListAllMenu();
    public void ListSpecificMenu();
}

internal class MenuService : IMenuService
{

    private readonly IUserService _userService = new UserService();

    public void MainMenu()
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("[1] Skapa ny användare");
            Console.WriteLine("[2] Visa en specifik användare");
            Console.WriteLine("[3] Visa alla användare");
            Console.WriteLine("[0] Avsluta");
            Console.WriteLine("Välj ett av ovanstående alternativ (0-4): ");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreateMenu();
                    break;

                case "2":
                    ListSpecificMenu();
                    break;

                case "3":
                    ListAllMenu();
                    break;

                case "0":
                    exit = true;
                    break;

                default:
                    break;
            }

        } while (exit == false);
    }

    public void CreateMenu()
    {
        string answer = "n";

        do
        {

            Console.Clear();
            Console.WriteLine(@"  ____  _                                                                   _   _           _                
     / ___|| | ____ _ _ __   __ _    ___ _ __    _ __  _   _    __ _ _ ____   _(_)_(_)_ __   __| | __ _ _ __ ___ 
     \___ \| |/ / _` | '_ \ / _` |  / _ \ '_ \  | '_ \| | | |  / _` | '_ \ \ / // _` | '_ \ / _` |/ _` | '__/ _ \
      ___) |   < (_| | |_) | (_| | |  __/ | | | | | | | |_| | | (_| | | | \ V /| (_| | | | | (_| | (_| | | |  __/
     |____/|_|\_\__,_| .__/ \__,_|  \___|_| |_| |_| |_|\__, |  \__,_|_| |_|\_/  \__,_|_| |_|\__,_|\__,_|_|  \___|
                     |_|                               |___/
    ");

            var user = new UserCreateRequest();

            Console.Write("Förnamn: ");
            user.FirstName = Console.ReadLine()!.Trim();

            Console.Write("Efternamn: ");
            user.LastName = Console.ReadLine()!.Trim();

            Console.Write("E-postadress: ");
            user.Email = Console.ReadLine()!.ToLower();

            Console.Write("Lösenord: ");
            user.Password = Console.ReadLine()!.Trim();

            _userService.Create(user);
            Console.WriteLine("En ny användare har blivit tillagd.");

            Console.WriteLine("Vill du lägga till fler kontakter? (y/n): ");
            answer = Console.ReadLine() ?? "";

        } while (answer!.ToLower() == "y");

    }

    public void ListAllMenu()
    {
        Console.Clear();
        Console.WriteLine(@"     _    _ _                          _   _           _                
    / \  | | | __ _    __ _ _ ____   _(_)_(_)_ __   __| | __ _ _ __ ___ 
   / _ \ | | |/ _` |  / _` | '_ \ \ / // _` | '_ \ / _` |/ _` | '__/ _ \
  / ___ \| | | (_| | | (_| | | | \ V /| (_| | | | | (_| | (_| | | |  __/
 /_/   \_\_|_|\__,_|  \__,_|_| |_|\_/  \__,_|_| |_|\__,_|\__,_|_|  \___|

");

        foreach (var user in _userService.GetAll())
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");

        Console.ReadKey();
        
    }

    public void ListSpecificMenu()
    {
        Console.Clear();
        Console.WriteLine(@"  ____  _   _ _                       _   _           _                
 / ___|(_)_(_) | __   __ _ _ ____   _(_)_(_)_ __   __| | __ _ _ __ ___ 
 \___ \ / _ \| |/ /  / _` | '_ \ \ / // _` | '_ \ / _` |/ _` | '__/ _ \
  ___) | (_) |   <  | (_| | | | \ V /| (_| | | | | (_| | (_| | | |  __/
 |____/ \___/|_|\_\  \__,_|_| |_|\_/  \__,_|_| |_|\__,_|\__,_|_|  \___|

");
        Console.Write("Ange e-postadress: ");
        var email = Console.ReadLine()!.Trim().ToLower();

        var user = _userService.Get(user => user.Email == email);

        if ( user != null)
            Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
        else
            Console.WriteLine($"Kunde inte hitta någon användare med e-postadressen {email}");

        Console.ReadKey();
    }

}

