using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen.Mvvm.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }



}
