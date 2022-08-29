using System.Threading.Tasks;

namespace Book.Data;

public interface IBookDbSchemaMigrator
{
    Task MigrateAsync();
}
