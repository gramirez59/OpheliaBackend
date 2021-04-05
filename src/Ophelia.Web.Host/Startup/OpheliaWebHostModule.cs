using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ophelia.Configuration;

namespace Ophelia.Web.Host.Startup
{
    [DependsOn(
       typeof(OpheliaWebCoreModule))]
    public class OpheliaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OpheliaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OpheliaWebHostModule).GetAssembly());
        }
    }
}
