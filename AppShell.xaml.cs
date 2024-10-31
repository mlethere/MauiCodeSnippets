using MauiCodeSnippets.InternetConnectivity;
using MauiCodeSnippets.MvvmExample2;

namespace MauiCodeSnippets
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Added for MvvmExample2 ...
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(IsConnectedPage), typeof(IsConnectedPage));
        }
    }
}
