using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;

namespace CED.Models.TokenAuth
{   /// <summary>
    /// template comments
    /// </summary>
    public class AuthenticateModel
    {   /// <summary>
        /// template comments
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string UserNameOrEmailAddress { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public bool RememberClient { get; set; }
    }
}
