using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;

namespace CimoApp.Mvvm.Views;

[QueryProperty(nameof(ContactM), "Contact")]
public partial class EditPage : ContentPage
{

    ContactModel contact;


    public ContactModel ContactM
    {
        get => contact;
        set
        {
            contact = value;
            OnPropertyChanged();

            if (BindingContext is EditViewModel viewModel)
            {
                viewModel.Contact = ContactM;
            }

        }
    }

    public EditPage(EditViewModel viewModel)
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
