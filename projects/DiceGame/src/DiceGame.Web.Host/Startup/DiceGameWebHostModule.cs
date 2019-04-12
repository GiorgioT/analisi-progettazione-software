using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DiceGame.Configuration;

namespace DiceGame.Web.Host.Startup
{
    [DependsOn(
       typeof(DiceGameWebCoreModule))]
    public class DiceGameWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DiceGameWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DiceGameWebHostModule).GetAssembly());
        }
    }
}
