using MauiCodeSnippets.ApiClientExample;
using MauiCodeSnippets.Crud.Views;
using MauiCodeSnippets.DateTimePickerExamples;
using MauiCodeSnippets.GlobalViewModelExample;
using MauiCodeSnippets.InternetConnectivity;
using MauiCodeSnippets.MvvmExample2;
using MauiCodeSnippets.Popups;
using MauiCodeSnippets.RoutingWithParameters;

namespace MauiCodeSnippets
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(IsConnectedPage), typeof(IsConnectedPage));
            Routing.RegisterRoute(nameof(DT_ExamplePage), typeof(DT_ExamplePage));
            Routing.RegisterRoute(nameof(ApiClientExamplePage), typeof(ApiClientExamplePage));
            Routing.RegisterRoute(nameof(GlobalViewModelPage1), typeof(GlobalViewModelPage1));
            Routing.RegisterRoute(nameof(GlobalViewModelPage2), typeof(GlobalViewModelPage2));
            Routing.RegisterRoute(nameof(CrudMainPage), typeof(CrudMainPage));
            Routing.RegisterRoute(nameof(LandingPage), typeof(LandingPage));
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        }
    }
}
