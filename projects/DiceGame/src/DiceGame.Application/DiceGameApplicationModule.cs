using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DiceGame.Authorization;

namespace DiceGame
{
    [DependsOn(
        typeof(DiceGameCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DiceGameApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DiceGameAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DiceGameApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
