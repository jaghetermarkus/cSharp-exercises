using System.Collections.ObjectModel;
using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.Views;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();


    public MainViewModel()
    {
        UpdateContacts();
        ContactService.ContactsUpdated += UpdateContacts;

    }


    void UpdateContacts()
    {
        Contacts.Clear();

            foreach (var contact in ContactService.GetContacts())
                Contacts.Add(contact);
    }

    /* LoadContact ??
    public async Task LoadContact(string contactEmail)
    {
        await ContactService.LoadContactByEmail(contactEmail);
    }
    */



    [RelayCommand]
    async Task GoToAdd()
    {
        await Shell.Current.GoToAsync(nameof(AddPage));
    }

    [RelayCommand]
    async Task GoToDetail(ContactModel contact)
    {
        await Shell.Current.GoToAsync(nameof(DetailPage),
            new Dictionary<string, object>
            {
                { "Contact", contact }
            });
    }

    [RelayCommand]
    async Task GoToUpdate(ContactModel contact)
    {
        await Shell.Current.GoToAsync(nameof(EditPage),
            new Dictionary<string, object>
            {
                { "Contact", contact }
            });
    }

    [RelayCommand]
    async Task Detail(ContactModel contact)
    {
        await Shell.Current.GoToAsync(nameof(DetailPage));

    }

    [RelayCommand]
    void DeleteContact(ContactModel contact)
    {
        ContactService.DeleteContact(contact);
        UpdateContacts();
    }

}

