using System;
using _01_Classes.Models;

namespace _01_Classes.Services;

public class CustomerService
{
    // service = 90% Methods

    // private_fields

    private List<Customer> _customerList;


    // Cunstructors

    // Properties

    // Methods

    public void CreateCustomer(Customer customer)
    {
        if (!_customerList.Contains(customer))
            _customerList.Add(customer);
    }


    public void GetCustomer() { }
    public List<Customer> GetCustomers()
    {
        return _customerList.OrderBy(x => x.id).ToList(); // vid användning av return så måste det alltid specificeras vad för format jag vill returner. Ex. int, string osv... i detta fall byts void till List<>...
    }
    public void UpdateCustomer() { }
    public void DeleteCustomer() { }

}

