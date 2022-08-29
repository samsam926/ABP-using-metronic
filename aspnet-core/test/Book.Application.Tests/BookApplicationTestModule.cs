using Volo.Abp.Modularity;

namespace Book;

[DependsOn(
    typeof(BookApplicationModule),
    typeof(BookDomainTestModule)
    )]
public class BookApplicationTestModule : AbpModule
{

}
