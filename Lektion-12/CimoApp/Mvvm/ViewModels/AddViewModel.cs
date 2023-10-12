using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels;

public partial class AddViewModel : ObservableObject
{
    [ObservableProperty]
    ContactModel contact = new ContactModel();


    [RelayCommand]
    async Task Add()
    {
        // Lägg till i lista
        ContactService.AddToList(Contact);
        // Nollställ kontakten
        Contact = new ContactModel();
        // NAvigerar tillbaka en sida
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}

