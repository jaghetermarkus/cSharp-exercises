using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels;

public partial class EditViewModel : ObservableObject
{

    [ObservableProperty]
    ContactModel contact = new ContactModel();

    [RelayCommand]
    async Task SaveChanges(ContactModel updatedContact)
    {
        await Shell.Current.GoToAsync("..",
            new Dictionary<string, object>
            {
                { "updatedContact", updatedContact }
            });
    }


    /*
    private readonly ContactService contactService;

    public EditViewModel(ContactService contactService)
    {
        this.contactService = contactService;
    }

    [RelayCommand]
    async Task SaveChanges(ContactModel updatedContact)
    {
        //contactService.UpdateContact(updatedContact);
        await Shell.Current.GoToAsync("..");
    }
     */



}

