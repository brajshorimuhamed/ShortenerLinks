using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities.Repositories.Repository_Abstracts
{
    public interface IRepostory
    {
        IEnumerable<ShortLink> GetLinks();
        ShortLink GetItemByShortUrl(string shortUrl);
        ShortLink GetItemByLongUrl(string longUrl);

        ShortLink SaveItemToDataStore(ShortLink model);
    }
}
