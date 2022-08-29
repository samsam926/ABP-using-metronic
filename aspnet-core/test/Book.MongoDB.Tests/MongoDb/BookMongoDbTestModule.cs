﻿using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Book.MongoDB;

[DependsOn(
    typeof(BookTestBaseModule),
    typeof(BookMongoDbModule)
    )]
public class BookMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = BookMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
