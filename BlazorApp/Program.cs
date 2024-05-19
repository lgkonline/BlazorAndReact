using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using Microsoft.FluentUI.AspNetCore.Components;
using System.Globalization;
using Microsoft.AspNetCore.Builder;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddLocalization();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("de")
    };

    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

builder.RootComponents.RegisterCustomElement<App>("internal-todo");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFluentUIComponents();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.RootComponents.RegisterCustomElement<MyTodo>("my-todo");
builder.RootComponents.RegisterCustomElement<MyTheme>("my-theme");

await builder.Build().RunAsync();
