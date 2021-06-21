using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities.Services.Service_Abstracts
{
    public interface IShortUrlService
    {
        IEnumerable<ShortLink> GetLinks_Service();
        ShortLink GetItemFromDataStore(string shortUrl);
        ShortURLResponseModel SaveItemToDataStore(ShortURLRequestModel model);
    }
}
