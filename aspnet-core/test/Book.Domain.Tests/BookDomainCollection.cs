using Book.MongoDB;
using Xunit;

namespace Book;

[CollectionDefinition(BookTestConsts.CollectionDefinitionName)]
public class BookDomainCollection : BookMongoDbCollectionFixtureBase
{

}
