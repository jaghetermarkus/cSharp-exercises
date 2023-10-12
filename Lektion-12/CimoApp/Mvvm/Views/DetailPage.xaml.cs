using System.ComponentModel;
using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.Views;

[QueryProperty(nameof(ContactM), "Contact")]
public partial class DetailPage : ContentPage
{

    ContactModel contact;


    public ContactModel ContactM
    {
        get => contact;
        set
        {
            contact = value;
            OnPropertyChanged();

            if (BindingContext is DetailViewModel viewModel)
            {
                viewModel.Contact = ContactM;
            }

        }
    }

	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
        viewModel.Contact = ContactM;
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs e)
    {
        base.OnNavigatedTo(e);

    }



}
