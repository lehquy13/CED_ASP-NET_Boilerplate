using Abp.AutoMapper;
using CED.Authentication.External;

namespace CED.Models.TokenAuth
{
    /// <summary>
    /// template comments
    /// </summary>
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {   
        /// <summary>
        /// template comments
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// template comments
        /// </summary>
        public string ClientId { get; set; }
    }
}
