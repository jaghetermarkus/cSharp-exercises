using System.Linq;
using System.Linq.Expressions;
using _01_Exercise.Interfaces;
using _01_Exercise.Models;

namespace _01_Exercise.Services;

internal class UserService : IUserService
{

    private List<User> _users = new List<User>();

    public void Create(UserCreateRequest userCreateRequest)
    {
        _users.Add(new User
        {
            Id = Guid.NewGuid(),
            FirstName = userCreateRequest.FirstName,
            LastName = userCreateRequest.LastName,
            Email = userCreateRequest.Email
        }); ;

        // Lösenord får vi hantera separat, av säkerhetsskäl...
    }

    public User Get(Func<User, bool> expression)
    {
        
        var user = _users.FirstOrDefault(expression, null!);
        return user;

        /* ALTERNATIVT SÄTT
        // Annat sätt att skriva ovan på. Det negativa med ovan exempel är att man kan inte välja alternativ för om 'user == null'. Exempelvis om man vill aktivera annan metod eller liknande. 
        var user = _users.FirstOrDefault(expression);
        if (user != null)
            return user!;

        return null!;
        */
    }

    /* EJ GÅTT IGENOM...
    public User Get(Expression<Func<User, bool>> expression)
    {
        throw new NotImplementedException();
    }
    */

    public IEnumerable<User> GetAll()
    {
        return _users;
    }
}

