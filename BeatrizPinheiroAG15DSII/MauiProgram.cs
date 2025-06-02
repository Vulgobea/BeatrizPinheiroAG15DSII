using Microsoft.Extensions.Logging;

namespace BeatrizPinheiroAG15DSII
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
                    fonts.AddFont("PlaypenSansDeva-Bold.ttf", "Deva-Bold");
                    fonts.AddFont("PlaypenSansDeva-ExtraBold.ttf", "Deva-ExtraBold");
                    fonts.AddFont("PlaypenSansDeva-ExtraLight.ttf", "Deva-ExtraLight");
                    fonts.AddFont("PlaypenSansDeva-Light.ttf", "Deva-Light");
                    fonts.AddFont("PlaypenSansDeva-Medium.ttf", "Deva-Medium");
                    fonts.AddFont("PlaypenSansDeva-Regular.ttf", "Deva-Regular");
                    fonts.AddFont("PlaypenSansDeva-SemiBold.ttf", "Deva-SemiBold");
                    fonts.AddFont("PlaypenSansDeva-Thin.ttf", "Deva-Thin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
