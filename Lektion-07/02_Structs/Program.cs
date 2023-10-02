
using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Value_Semantics;


// Matematiska Modeller
Vector2D vector = new Vector2D(3.0, 4.0);
Console.WriteLine($"Vector: X={vector.X}, Y={vector.Y}");
Console.ReadKey();

// Interoprabilitet (arbete mot externa bibliotek/API och har ett simplifierat objekt som ska symbolisera samma sak)
Todo todo = new Todo() { UserId = 1, Id = 1, Title = "delectus aut autem", Completed = false };
Console.WriteLine($"Todo: {todo.Id} - {todo.Title}");
Console.ReadKey();

// Prestanda-känsliga Applikationer
RgbColor color = new RgbColor(255, 0, 0);
Console.WriteLine($"Color: R={color.R}, G={color.G}, B={color.B}");
Console.ReadKey();

// Värdesemantik
Money salary = new Money(5000M, "SEK");
Console.WriteLine($"Money: Amount={salary.Amount}, Currency={salary.Currency}");
Console.ReadKey();

// Domain Driven Design (DDD)
User user = new User
{
    FirstName = "Markus",
    LastName = "Karlsson",
    Email = new Email("Markus@domain.com"),
    Password = new Password("BytMig123!")
};
Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
Console.ReadKey();