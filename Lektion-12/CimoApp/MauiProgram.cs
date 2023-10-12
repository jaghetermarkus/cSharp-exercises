using CimoApp.Mvvm.ViewModels;
using CimoApp.Mvvm.Views;
using CimoApp.Services;
using Microsoft.Extensions.Logging;

namespace CimoApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ContactService>();

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<AddViewModel>();
        builder.Services.AddSingleton<AddPage>();

        builder.Services.AddTransient<EditViewModel>();
        builder.Services.AddTransient<EditPage>();

        builder.Services.AddSingleton<DetailViewModel>();
        builder.Services.AddSingleton<DetailPage>();

        return builder.Build();
	}
}

