using _01_Assignment_Example.Models;

namespace _01_Assignment_Example.Interfaces;

public interface ICustomer
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    string? Email { get; set; }
    IAddress? Address { get; set; }

    string FullName { get; }
}