using ShortenerLinks.Models.Entities.Repositories.Repository_Abstracts;
using ShortenerLinks.Models.Entities.Services.Map;
using ShortenerLinks.Models.Entities.Services.Service_Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities.Services
{
    public class ShortLinkService : IShortUrlService
    {
        private IRepostory shortUrlRepository;

        public ShortLinkService(IRepostory repostory)
        {
            shortUrlRepository = repostory;
        }

        public ShortLink GetItemFromDataStore(string shortUrl)
        {
            return shortUrlRepository.GetItemByShortUrl(shortUrl);
        }

        public IEnumerable<ShortLink> GetLinks_Service()
        {
            return shortUrlRepository.GetLinks();
        }

        public ShortURLResponseModel SaveItemToDataStore(ShortURLRequestModel model)
        {
            ShortLink previouslySaved = shortUrlRepository.GetItemByLongUrl(model.LongUrl);
            if (previouslySaved != null)
            {
                return new ShortURLResponseModel { Model = previouslySaved, Success = true, Message = "This url has been saved previously" };
            }
            else
            {
                ShortLink savedModel = shortUrlRepository.SaveItemToDataStore(ShortUrlModelMapper.MapRequestModelToDBModel(model));

                return new ShortURLResponseModel
                {
                    Model = savedModel,
                    Success = true,
                    Message = "Saved Successfully"
                };
            }
        }
    }
}
