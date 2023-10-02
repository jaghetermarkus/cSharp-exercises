using _01_Assignment_Example.Interfaces;
using Newtonsoft.Json;

namespace _01_Assignment_Example.Services;

public class CustomerService : ICustomerService
{

    private List<ICustomer> _customers = new List<ICustomer>();
    private readonly string _filePath = @"/Users/markuskarlsson/Nackademin/cSharp/exercises/Lektion-09/ListOfCustomers.json";

    public async Task AddCustomerAsync(ICustomer customer)
    {
        _customers.Add(customer);
        await FileService.SaveToFileAsync(_filePath, JsonConvert.SerializeObject(_customers));
    }


    public IEnumerable<ICustomer> GetAllCustomers()
    {
        return _customers;
    }


    public ICustomer GetOneCustomer(string email)
    {
        return _customers.FirstOrDefault(x => x.Email?.ToLower() == email.ToLower())!; 
    }

    public void RemoveCustomer(string email)
    {
        var customer = GetOneCustomer(email);
        _customers.Remove(customer);
    }
}

