﻿using Microsoft.Extensions.Logging;
using ToDOMauiClient.DataServices;

namespace ToDOMauiClient;

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

		builder.Services.AddSingleton<IRestDataService, RestDataService>();

		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
