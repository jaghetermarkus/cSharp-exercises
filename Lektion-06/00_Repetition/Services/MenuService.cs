using _00_Repetition.Interfaces;
using _00_Repetition.Models;

namespace _00_Repetition.Services;

public class MenuService : IMenuService
{

    private readonly IToDoService _todoService = new ToDoService();

    public void MainMenu()
    {

        do
        {
            Console.Clear();
            Console.WriteLine("ATT-GÖRA LISTAN");
            Console.WriteLine("--------------------");
            Console.WriteLine("[1] Lägg till ny aktivitet");
            Console.WriteLine("[2] Visa alla aktiviteter");
            Console.WriteLine("[3] Ta bort en aktivitet");
            Console.WriteLine("Ange ett av alternativen ovan: ");
            var userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                    AddMenu();
                    break;

                case "2":
                    ListMenu();
                    break;

                case "3":
                    DeleteMenu();
                    break;

            }

        } while (true);
    }

    public void AddMenu()
    {
        var todo = new ToDo();

        Console.Clear();
        Console.WriteLine("Ange aktivitet: ");
        todo.Activity = Console.ReadLine()!;

        _todoService.AddToList(todo);
        Console.WriteLine("Ny aktivitet har lagts till i din ATT-GÖRA lista.");
        Console.ReadKey();

    }

    public void ListMenu()
    {
        Console.Clear();
        Console.WriteLine("ATT-GÖRA LISTAN");
        Console.WriteLine("--------------------");

        foreach (var todo in _todoService.GetAll())
        {
            Console.WriteLine($"{todo.Activity}");
            Console.WriteLine($"{todo.Id} - {todo.Created}");
            Console.WriteLine("---");
        }

        Console.ReadKey();
    }


    public void DeleteMenu()
    {
        try
        {
        Console.Clear();
        Console.WriteLine("Ange id: ");
        var id = Console.ReadLine()!;
        _todoService.Delete(new Guid(id));
        }
        catch { }

    }




}

