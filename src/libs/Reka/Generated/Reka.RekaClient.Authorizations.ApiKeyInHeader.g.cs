
#nullable enable

namespace Reka
{
    public sealed partial class RekaClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Reka.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-Api-Key",
                Value = apiKey,
            });
        }
    }
}