namespace ChatApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Metropolis-Black.otf", "Metropolis Black");
				fonts.AddFont("Metropolis-Light.ttf", "Metropolis Light");
				fonts.AddFont("Metropolis-Medium.ttf", "Metropolis Medium");
				fonts.AddFont("Metropolis-Regular.ttf", "Metropolis Regular");
			});

		return builder.Build();
	}
}
