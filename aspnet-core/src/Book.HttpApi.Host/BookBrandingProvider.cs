using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Book;

[Dependency(ReplaceServices = true)]
public class BookBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Book";
}
