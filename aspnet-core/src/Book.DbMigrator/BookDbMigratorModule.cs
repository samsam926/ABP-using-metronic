using Book.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Book.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookMongoDbModule),
    typeof(BookApplicationContractsModule)
    )]
public class BookDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
