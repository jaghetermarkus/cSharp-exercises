using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels;

public partial class EditViewModel : ObservableObject
{
    private readonly ContactService contactService;

    [ObservableProperty]
    ContactModel contact = new ContactModel();

    public EditViewModel(ContactService contactService)
    {
        this.contactService = contactService;
    }

    [RelayCommand]
    public async Task SaveChanges(ContactModel updatedContact)
    {
        contactService.UpdateContact(updatedContact);
        await Shell.Current.GoToAsync("..");
    }

   
}

