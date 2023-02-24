using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public class ExternalAuthManager : IExternalAuthManager, ITransientDependency
    {
        private readonly IIocResolver _iocResolver;
        private readonly IExternalAuthConfiguration _externalAuthConfiguration;
        /// <summary>
        /// template comments
        /// </summary>
        public ExternalAuthManager(IIocResolver iocResolver, IExternalAuthConfiguration externalAuthConfiguration)
        {
            _iocResolver = iocResolver;
            _externalAuthConfiguration = externalAuthConfiguration;
        }
        /// <summary>
        /// template comments
        /// </summary>
        public Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode)
        {
            using (var providerApi = CreateProviderApi(provider))
            {
                return providerApi.Object.IsValidUser(providerKey, providerAccessCode);
            }
        }
        /// <summary>
        /// template comments
        /// </summary>
        public Task<ExternalAuthUserInfo> GetUserInfo(string provider, string accessCode)
        {
            using (var providerApi = CreateProviderApi(provider))
            {
                return providerApi.Object.GetUserInfo(accessCode);
            }
        }
        /// <summary>
        /// template comments
        /// </summary>
        public IDisposableDependencyObjectWrapper<IExternalAuthProviderApi> CreateProviderApi(string provider)
        {
            var providerInfo = _externalAuthConfiguration.Providers.FirstOrDefault(p => p.Name == provider);
            if (providerInfo == null)
            {
                throw new Exception("Unknown external auth provider: " + provider);
            }

            var providerApi = _iocResolver.ResolveAsDisposable<IExternalAuthProviderApi>(providerInfo.ProviderApiType);
            providerApi.Object.Initialize(providerInfo);
            return providerApi;
        }
    }
}
