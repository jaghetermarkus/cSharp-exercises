using static _02_AsyncAwait.Services.MenuService;

namespace _02_AsyncAwait.Services;

public class UserService
{
    public static async Task SaveUserAsync(User user)
    {
        // Saving data to database
        // Doing some work here...
        await Task.Delay(15000);
        Console.WriteLine("TASK DONE!");
    }
}

