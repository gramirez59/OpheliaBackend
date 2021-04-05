using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ophelia.Authorization;

namespace Ophelia
{
    [DependsOn(
        typeof(OpheliaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OpheliaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OpheliaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OpheliaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
