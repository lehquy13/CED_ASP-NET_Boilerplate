using System.Collections.Generic;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public interface IExternalAuthConfiguration
    {
        /// <summary>
        /// template comments
        /// </summary>
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
