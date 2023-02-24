using System.Collections.Generic;
using Abp.Dependency;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public class ExternalAuthConfiguration : IExternalAuthConfiguration, ISingletonDependency
    {
        /// <summary>
        /// template comments
        /// </summary>
        public List<ExternalLoginProviderInfo> Providers { get; }

        /// <summary>
        /// template comments
        /// </summary>
        public ExternalAuthConfiguration()
        {
            Providers = new List<ExternalLoginProviderInfo>();
        }
    }
}
