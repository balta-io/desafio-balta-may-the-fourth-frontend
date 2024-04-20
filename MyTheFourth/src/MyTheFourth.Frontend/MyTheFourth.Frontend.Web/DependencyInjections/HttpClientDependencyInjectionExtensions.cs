using MyTheFourth.Frontend.Web.Client.Services;
using MyTheFourth.Frontend.Web.Http.Handlers;

namespace MyTheFourth.Frontend.Web.DependencyInjections;

public static class HttpClientDependencyInjectionExtensions
{
    public static IServiceCollection AddApiHttpService(this IServiceCollection services)
    {

        services.AddHttpClient<MyTheFourthHttpService>("Default", (httpclient) =>
        {
            httpclient.BaseAddress = new Uri("http://");
        }).AddHttpMessageHandler(provider => provider.GetService<ApiDelegatingHandler>()!);

        var implementationType = typeof(MyTheFourthHttpService);

        var interfaces = implementationType.GetInterfaces();

        foreach (var type in interfaces)
        {
            services.AddTransient(type, provider => provider.GetRequiredService<MyTheFourthHttpService>());
        }

        services.AddTransient<ApiDelegatingHandler>();

        return services;
    }

    public static IServiceCollection AddApiHttpServiceFake(this IServiceCollection services)
    {
        services.AddScoped<MyTheFourthHttpServiceFake>();

        var implementationType = typeof(MyTheFourthHttpServiceFake);


        var interfaces = implementationType.GetInterfaces();

        foreach (var type in interfaces)
        {
            services.AddTransient(type, provider => provider.GetRequiredService<MyTheFourthHttpServiceFake>());
        }


        return services;
    }


}