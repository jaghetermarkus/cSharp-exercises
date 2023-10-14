using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;
using CimoApp.Services;

namespace CimoApp.Mvvm.Views;

[QueryProperty(nameof(UpdatedContact), "updatedContact")]
public partial class MainPage : ContentPage
{
    private ContactModel updatedContact; 

    public ContactModel UpdatedContact
    {
        set
        {
            updatedContact = value;
            UpdateOneContact(updatedContact);
        }
    }

    public void UpdateOneContact(ContactModel contact)
    {
        ContactService.SaveUpdatedContact(contact);
    }

    public MainPage(MainViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }


}


