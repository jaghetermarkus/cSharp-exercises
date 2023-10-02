namespace _02_AsyncAwait.Services;

public class MenuService
{
    public record User(string Name, string Email);

    public static void AddUserMenu()
    {
        var user = new User("Markus", "markus@domain.com");

        Console.WriteLine("Starting....");
        Console.WriteLine("Saving user to database");

        Task.Run(async () => await UserService.SaveUserAsync(user));

        Console.WriteLine("Continue doing some work");
    }
}

