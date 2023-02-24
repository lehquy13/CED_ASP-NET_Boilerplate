using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace CED.Configuration
{
    /// <summary>
    /// template comments
    /// </summary>
    public static class HostingEnvironmentExtensions
    {   
        /// <summary>
        /// template comments
        /// </summary>
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
