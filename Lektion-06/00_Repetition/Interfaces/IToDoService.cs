using _00_Repetition.Models;

namespace _00_Repetition.Interfaces;

public interface IToDoService
{
    void AddToList(ToDo todo);
    IEnumerable<ToDo> GetAll();
    void Delete(Guid id);
}

