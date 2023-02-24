using System.Threading.Tasks;
using Abp.Dependency;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public abstract class ExternalAuthProviderApiBase : IExternalAuthProviderApi, ITransientDependency
    {
        /// <summary>
        /// template comments
        /// </summary>
        public ExternalLoginProviderInfo ProviderInfo { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public void Initialize(ExternalLoginProviderInfo providerInfo)
        {
            ProviderInfo = providerInfo;
        }
        /// <summary>
        /// template comments
        /// </summary>
        public async Task<bool> IsValidUser(string userId, string accessCode)
        {
            var userInfo = await GetUserInfo(accessCode);
            return userInfo.ProviderKey == userId;
        }
        /// <summary>
        /// template comments
        /// </summary>
        public abstract Task<ExternalAuthUserInfo> GetUserInfo(string accessCode);
    }
}
