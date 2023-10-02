using _01_DataLogging.Interfaces;
using _01_DataLogging.Models;

namespace _01_DataLogging.Tests.Tests;

public class UserManager_Tests
{
    [Fact]
    public void CreateUser_Should_CreateNewUserAndAddUserToList_ReturnCreatedUser()
    {
        // Arrange
        string password = "BytMig123!";
        IUser user = new User
        {
            FirstName = "Markus",
            LastName = "Karlsson",
            Email = "Markus@domain.com"
        };

        IUserManager userManager = new UserManager();


        // Act
        IUser result = userManager.CreateUser(user, password)


        // Assert
        Assert.NotNull(result);
        Assert.IsAssignableFrom<IUser>(result);

    }

}

