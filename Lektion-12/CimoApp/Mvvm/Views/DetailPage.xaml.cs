﻿using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.ViewModels;

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
                viewModel.ContactC = ContactM;
            }

        }
    }

	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
        viewModel.ContactC = ContactM;
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs e)
    {
        base.OnNavigatedTo(e);

    }



}
