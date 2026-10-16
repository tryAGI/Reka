namespace Reka;

public sealed partial class RekaClient
{
    /// <summary>
    /// Sets the API key using the Bearer authentication required by the Reka API.
    /// Retains the previous method name for source compatibility.
    /// </summary>
    /// <param name="apiKey">The Reka API key.</param>
    public void AuthorizeUsingApiKeyInHeader(string apiKey) => AuthorizeUsingBearer(apiKey);
}

public partial interface IRekaClient
{
    /// <summary>
    /// Sets the API key using Bearer authentication.
    /// </summary>
    /// <param name="apiKey">The Reka API key.</param>
    void AuthorizeUsingApiKeyInHeader(string apiKey);
}
