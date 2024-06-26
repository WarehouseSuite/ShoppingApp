namespace Shop.Infrastructure.Http;

internal static class HttpExtentions
{
    internal static void SetAuthenticationHeader( this HttpClient http, string? token )
    {
        http.DefaultRequestHeaders.Authorization = !string.IsNullOrWhiteSpace( token )
            ? new System.Net.Http.Headers.AuthenticationHeaderValue( "Bearer", token )
            : null;
    }
}