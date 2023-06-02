﻿namespace ProductionApp.WebUI.Extensions;

public static class ServicesExtensions
{
    public static void ToasterExtension(this IServiceCollection services)
    {
        services.AddNotyf(opt =>
        {
            opt.DurationInSeconds = 10;
            opt.IsDismissable = true;
            opt.Position = NotyfPosition.BottomRight;
        });
    }

    public static void SeedDataExtension(this IServiceCollection services)
    {
        using var scope = services.BuildServiceProvider().CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
        SeedData.InitializeAsync(scope.ServiceProvider).Wait();
    }
}
