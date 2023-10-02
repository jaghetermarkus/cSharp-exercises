using _03_Records.Records;

var user = new User("Markus", "Karlsson", "Markus@domain.com");
//user.firstName = "Johan"; <--Såhär får man inte göra. Därför är inte Records så användbart i de flesta fall.
Console.WriteLine($"{user.firstName} {user.lastName} {user.email}");
Console.ReadKey();
