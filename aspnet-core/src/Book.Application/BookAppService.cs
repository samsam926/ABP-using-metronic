using System;
using System.Collections.Generic;
using System.Text;
using Book.Localization;
using Volo.Abp.Application.Services;

namespace Book;

/* Inherit your application services from this class.
 */
public abstract class BookAppService : ApplicationService
{
    protected BookAppService()
    {
        LocalizationResource = typeof(BookResource);
    }
}
