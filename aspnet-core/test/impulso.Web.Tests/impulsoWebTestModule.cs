using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using impulso.EntityFrameworkCore;
using impulso.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace impulso.Web.Tests
{
    [DependsOn(
        typeof(impulsoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class impulsoWebTestModule : AbpModule
    {
        public impulsoWebTestModule(impulsoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(impulsoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(impulsoWebMvcModule).Assembly);
        }
    }
}