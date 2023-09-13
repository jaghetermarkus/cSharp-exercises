
using _01_Classes.Models;
using _01_Classes.Services;

/*  Access Moifiers
    -------------------------------

    private         accessbara bara inom scopet ( dvs { } ) som variablen ligger inom
    public          accessbar överallt i hela din solution, dvs även mellan olika projekt
    internal        accessbar överallt i hela ditt projekt, men inte mellan olika projekt

*/

// Vi gör en instans av en customerService så vi kan använda den
var customerService = new CustomerService();

customerService.GetCustomer();
var list = customerService._customerList; // kommer ej åt _customerList då den är privat i imon annan klass


customerService.GetCustomers();

list.Add(new Customer());



