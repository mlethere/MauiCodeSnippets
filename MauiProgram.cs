﻿using MauiCodeSnippets.MvvmExample2;
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

            return builder.Build();
        }
    }
}
