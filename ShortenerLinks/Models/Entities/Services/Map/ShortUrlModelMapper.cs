using ShortenerLinks.Models.Entities.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities.Services.Map
{
    public static class ShortUrlModelMapper
    {
        public static ShortLink MapRequestModelToDBModel(ShortURLRequestModel requestModel)
        {
            ShortLink result = new ShortLink
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                LongURL = requestModel.LongUrl
            };

            result.Url = $"https://gj.al/{result.ShortURL}";

            if (result.Url != null)
            {
                result.ShortURL = TokenGenerator.GenerateShortUrl();
            }

            

            return result;
        }
    }
}
