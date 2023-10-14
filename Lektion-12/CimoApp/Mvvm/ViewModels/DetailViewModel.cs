using System.ComponentModel;
using System.Runtime.CompilerServices;
using CimoApp.Mvvm.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CimoApp.Mvvm.ViewModels;

public partial class DetailViewModel : ObservableObject
{

    [ObservableProperty]
    ContactModel contactC = new ContactModel();

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

}



    /*
    public ContactModel User { get; set; }
    public DetailViewModel()
    {
    User = new ContactModel
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "555-1234"
        };
    }

    private ContactModel contact;

    public ContactModel Contact
    {
        get => contact;
        set => SetProperty(ref contact, value);
    }
     */

//public ContactModel Contact { get; set; }

/*
    public partial class DetailViewModel : INotifyPropertyChanged
    {
        private ContactModel contact;

        public ContactModel Contact
        {
            get => contact;
            set
            {
                if (contact != value)
                {
                    contact = value;
                    OnPropertyChanged();
                }
            }
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
*/
