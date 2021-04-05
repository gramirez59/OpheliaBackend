using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Ophelia.Configuration;
using Ophelia.Web;

namespace Ophelia.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OpheliaDbContextFactory : IDesignTimeDbContextFactory<OpheliaDbContext>
    {
        public OpheliaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OpheliaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OpheliaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OpheliaConsts.ConnectionStringName));

            return new OpheliaDbContext(builder.Options);
        }
    }
}
