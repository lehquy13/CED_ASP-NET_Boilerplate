using System;
using Microsoft.IdentityModel.Tokens;

namespace CED.Authentication.JwtBearer
{
    /// <summary>
    /// template comments
    /// </summary>
    public class TokenAuthConfiguration
    {
        /// <summary>
        /// template comments
        /// </summary>
        public SymmetricSecurityKey SecurityKey { get; set; }

        /// <summary>
        /// template comments
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// template comments
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// template comments
        /// </summary>
        public SigningCredentials SigningCredentials { get; set; }

        /// <summary>
        /// template comments
        /// </summary>
        public TimeSpan Expiration { get; set; }
    }
}
