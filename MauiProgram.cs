using CommunityToolkit.Maui;
using DevExpress.Maui;
using MauiCodeSnippets.ApiClientExample;
using MauiCodeSnippets.Crud.ViewModels;
using MauiCodeSnippets.Crud.Views;
using MauiCodeSnippets.GlobalViewModelExample;
using MauiCodeSnippets.InternetConnectivity;
using MauiCodeSnippets.MvvmExample2;
using MauiCodeSnippets.RoutingWithParameters;
using Microsoft.Extensions.Logging;

namespace MauiCodeSnippets
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseDevExpress()
                .UseDevExpressCharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // Added DI for BirthdayPage2ViewModel
            // Singleton is a global page. Loaded once
            // Transient is a new instance each time

            builder.Services.AddSingleton<BirthdayPage2>();
            builder.Services.AddSingleton<BirthdayPage2ViewModel>();
            builder.Services.AddTransient<DetailViewModel>();
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddSingleton<ApiClientExampleViewModel>();
            builder.Services.AddSingleton<ApiClientExamplePage>();
            
            // Used so that I can have a global view model.
            builder.Services.AddSingleton<GlobalViewModel>();
            builder.Services.AddSingleton<GlobalViewModelPage1>();
            builder.Services.AddSingleton<GlobalViewModelPage2>();

            // For the InternetConnectivity example
            builder.Services.AddSingleton<IsConnectedPage>();
            builder.Services.AddSingleton<IsConnectedViewModel>();
            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            builder.Services.AddTransient<CrudMainPage>();
            builder.Services.AddTransient<CrudMainViewModel>();

            builder.Services.AddSingleton<LandingPage>();
            builder.Services.AddSingleton<LandingViewModel>();
            builder.Services.AddSingleton<DetailsPage>();
            builder.Services.AddSingleton<DetailsViewModel>();

            // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/popup#building-a-popup
            //builder.Services.AddSingleton<CustomSizeAndPositionPopupPage>();
            //builder.Services.AddTransientPopup<UpdatingPopup, UpdatingPopupViewModel>();

            return builder.Build();
        }
    }
}
