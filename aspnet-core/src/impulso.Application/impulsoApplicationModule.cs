using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using impulso.Authorization;

namespace impulso
{
    [DependsOn(
        typeof(impulsoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class impulsoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<impulsoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(impulsoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
