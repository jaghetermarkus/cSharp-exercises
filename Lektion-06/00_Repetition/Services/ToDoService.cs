using _00_Repetition.Interfaces;
using _00_Repetition.Models;

namespace _00_Repetition.Services;

public class ToDoService : IToDoService
{

    private readonly List<ToDo> _list = new List<ToDo>();


    public void AddToList(ToDo todo)
    {
        _list.Add(todo);
    }


    public void Delete(Guid id)
    {
        var todo = _list.FirstOrDefault(x => x.Id == id);

        if (todo != null)
            _list.Remove(todo);
    }


    public IEnumerable<ToDo> GetAll()
    {
        return _list.OrderByDescending(todo => todo.Created);
    }

}

