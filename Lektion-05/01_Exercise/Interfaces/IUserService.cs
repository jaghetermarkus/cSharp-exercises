using System.Linq.Expressions;
using _01_Exercise.Models;

namespace _01_Exercise.Interfaces;

internal interface IUserService
{
    public void Create(UserCreateRequest userCreateRequest);
    public User Get(Func<User, bool> expression);
    public IEnumerable<User> GetAll();

    // public User Get(Expression<Func<User, bool>> expression);
}

