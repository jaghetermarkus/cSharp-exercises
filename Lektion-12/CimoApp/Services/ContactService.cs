using AutoMapper;
using CimoApp.Mvvm.Models;

namespace CimoApp.Services;

public class ContactService
{
    private static List<ContactModel> contacts = new List<ContactModel>();
    //private readonly IMapper mapper;
    public static event Action ContactsUpdated;
    /*
    public ContactService(IMapper mapper)
    {
        this.mapper = mapper;
    }
    */

    public static void AddToList(ContactModel contact)
    {
        contacts.Add(contact);
        ContactsUpdated.Invoke();
    }

    public static List<ContactModel> GetContacts()
    {
        return contacts;
    }

    public static ContactModel LoadContactByEmail(string contactEmail)
    {
        var contact = contacts.FirstOrDefault(x => x.Email == contactEmail);
        if (contact != null)
            return contact;

        return null;
    }

    public static void DeleteContact(ContactModel contact)
    {
        if (contact != null)
        {
        contacts.Remove(contact);
        }
    }

    public void UpdateContact(ContactModel updatedContact)
    {
        ContactModel existingContact = contacts.FirstOrDefault(x => x.Id == updatedContact.Id);

        if (existingContact != null)
        {

            // mapper.Map(updatedContact, existingContact);
            existingContact.FirstName = updatedContact.FirstName;
            existingContact.LastName = updatedContact.LastName;
            existingContact.Email = updatedContact.Email;
            existingContact.PhoneNumber = updatedContact.PhoneNumber;
        }
        OnContactsUpdated();
        
    }

    protected virtual void OnContactsUpdated()
    {
        ContactsUpdated?.Invoke();
    }


}

