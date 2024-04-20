
using MyTheFourth.Frontend.Web.Http.Handlers;
using MyTheFourth.Frontend.Web.Services;

public static class HttpClientDependencyInjectionExtensions
{
    public static IServiceCollection AddApiHttpService(this IServiceCollection services){

        services.AddHttpClient<MyTheFourthHttpService>("Default", (httpclient) => {
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

     public static IServiceCollection AddApiHttpServiceFake(this IServiceCollection services){

            var implementationType = typeof(MyTheFourthHttpService);

            var interfaces = implementationType.GetInterfaces();

            foreach (var type in interfaces)
            {
                services.AddTransient(type, provider => provider.GetRequiredService<MyTheFourthHttpService>());
            }


            return services;
    }


}
