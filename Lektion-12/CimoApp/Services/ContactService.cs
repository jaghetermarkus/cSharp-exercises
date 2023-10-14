using AutoMapper;
using CimoApp.Mvvm.Models;
using Newtonsoft.Json;

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
        JsonService.SaveToJson(JsonConvert.SerializeObject(contacts));
        ContactsUpdated.Invoke();
    }

    public static List<ContactModel> GetContacts()
    {
        var content = JsonService.ReadFromJson();
        if (!string.IsNullOrEmpty(content))
            contacts = JsonConvert.DeserializeObject<List<ContactModel>>(content)!;

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
        JsonService.SaveToJson(JsonConvert.SerializeObject(contacts));
        ContactsUpdated.Invoke();
    }

    public static void SaveUpdatedContact(ContactModel updatedContact)
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

        //OnContactsUpdated(); Hur får jag denna att funka trots att den är inuti en static
        JsonService.SaveToJson(JsonConvert.SerializeObject(contacts));
        ContactsUpdated.Invoke();

    }

    protected virtual void OnContactsUpdated()
    {
        JsonService.SaveToJson(JsonConvert.SerializeObject(contacts));
        ContactsUpdated?.Invoke();
    }


}

