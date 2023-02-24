using System;

namespace CED.Authentication.External
{   /// <summary>
    /// template comments
    /// </summary>
    public class ExternalLoginProviderInfo
    {   /// <summary>
        /// template comments
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public string ClientId { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public string ClientSecret { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public Type ProviderApiType { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public ExternalLoginProviderInfo(string name, string clientId, string clientSecret, Type providerApiType)
        {
            Name = name;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ProviderApiType = providerApiType;
        }
    }
}
