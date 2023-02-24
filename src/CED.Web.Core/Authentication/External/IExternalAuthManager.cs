using System.Threading.Tasks;

namespace CED.Authentication.External
{
    /// <summary>
    /// template comments
    /// </summary>
    public interface IExternalAuthManager
    {
        /// <summary>
        /// template comments
        /// </summary>
        Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode);
        /// <summary>
        /// template comments
        /// </summary>
        Task<ExternalAuthUserInfo> GetUserInfo(string provider, string accessCode);
    }
}
