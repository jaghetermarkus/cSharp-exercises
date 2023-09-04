using System;


namespace _04_ClassesAndLists.Models;

public class ContactPerson
	{
	public int Id { get; set; }
	public string FirstName { get; set; } = null!;
	public string LastName { get; set; } = null!;
	public string Email { get; set; } = null!; 
	public string? PhoneNumber { get; set; }	// Får eller kan vara tomt tack vare "?"

}

