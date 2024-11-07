using MauiCodeSnippets.GlobalViewModelExample;

namespace MauiCodeSnippets
{
    public partial class App : Application
    {
        /// <summary>
        /// This is a globally accessible viewModel. I am not sure what this does for me though.
        /// </summary>
        public static GlobalViewModel MyGlobalViewModel { get; set; } = new GlobalViewModel();

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
