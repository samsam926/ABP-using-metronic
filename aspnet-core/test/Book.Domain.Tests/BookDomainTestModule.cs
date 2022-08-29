using Book.MongoDB;
using Volo.Abp.Modularity;

namespace Book;

[DependsOn(
    typeof(BookMongoDbTestModule)
    )]
public class BookDomainTestModule : AbpModule
{

}
