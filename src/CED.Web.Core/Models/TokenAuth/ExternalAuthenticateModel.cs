using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace CED.Models.TokenAuth
{
    /// <summary>
    /// template comments
    /// </summary>
    public class ExternalAuthenticateModel
    {
        /// <summary>
        /// template comments
        /// </summary>
        [Required]
        [StringLength(UserLogin.MaxLoginProviderLength)]
        public string AuthProvider { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        [Required]
        [StringLength(UserLogin.MaxProviderKeyLength)]
        public string ProviderKey { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        [Required]
        public string ProviderAccessCode { get; set; }
    }
}
