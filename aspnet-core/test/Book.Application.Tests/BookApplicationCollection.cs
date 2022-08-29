using Book.MongoDB;
using Xunit;

namespace Book;

[CollectionDefinition(BookTestConsts.CollectionDefinitionName)]
public class BookApplicationCollection : BookMongoDbCollectionFixtureBase
{

}
