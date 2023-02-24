using System.Threading.Tasks;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public interface IExternalAuthProviderApi
    {
        /// <summary>
        /// template comments
        /// </summary>
        ExternalLoginProviderInfo ProviderInfo { get; }

        /// <summary>
        /// template comments
        /// </summary>
        Task<bool> IsValidUser(string userId, string accessCode);

        /// <summary>
        /// template comments
        /// </summary>
        Task<ExternalAuthUserInfo> GetUserInfo(string accessCode);

        /// <summary>
        /// template comments
        /// </summary>
        void Initialize(ExternalLoginProviderInfo providerInfo);
    }
}
