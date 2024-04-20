namespace MyTheFourth.Frontend.Web.Http.Handlers;

public class ApiDelegatingHandler : DelegatingHandler
{
    public ApiDelegatingHandler()
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        return base.SendAsync(request, cancellationToken);
    }
}