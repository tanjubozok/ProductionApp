using AspNetCoreHero.ToastNotification;

namespace ProductionApp.WebUI.Extensions;

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
}
