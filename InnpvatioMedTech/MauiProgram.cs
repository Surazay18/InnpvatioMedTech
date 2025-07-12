using InnpvatioMedTech.Pages;
using InnpvatioMedTech.Views;

namespace InnpvatioMedTech;

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

        // Register pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<PatientsPage>();

        // Register views
        builder.Services.AddTransient<DashboardView>();
        builder.Services.AddTransient<PatientsView>();


        return builder.Build();
    }
}