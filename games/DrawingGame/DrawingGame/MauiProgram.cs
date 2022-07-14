﻿using CommunityToolkit.Maui;
using DrawingGame.GameObjects;
using DrawingGame.Pages;
using DrawingGame.Scenes;
using Orbit.Engine;

namespace DrawingGame;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseOrbitEngine()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.Services
				.AddGameObjects()
				.AddPages()
				.AddScenes()
				.AddSingleton<DrawingManager>();

		return builder.Build();
	}
}
