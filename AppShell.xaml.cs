using MauiCodeSnippets.DateTimePickerExamples;
using MauiCodeSnippets.InternetConnectivity;
using MauiCodeSnippets.MvvmExample2;

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
        }
    }
}
