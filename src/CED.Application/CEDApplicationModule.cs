using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CED.Authorization;

namespace CED
{
    [DependsOn(
        typeof(CEDCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CEDApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CEDAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CEDApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
