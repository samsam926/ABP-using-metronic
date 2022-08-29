using Xunit;

namespace Book.MongoDB;

[CollectionDefinition(BookTestConsts.CollectionDefinitionName)]
public class BookMongoCollection : BookMongoDbCollectionFixtureBase
{

}
