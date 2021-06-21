using ShortenerLinks.Models.Contexts;
using ShortenerLinks.Models.Entities.Repositories.Repository_Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities.Repositories
{
    public class ShortURLRepository : IRepostory
    {
        private readonly ShortLinkDbContext _context;

        public ShortURLRepository(ShortLinkDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<ShortLink> GetLinks()
        {
            return _context.ShortLinks.ToList();
        }

        public ShortLink GetItemByLongUrl(string longUrl)
        {
            ShortLink query1 = _context.ShortLinks.Where(x => x.LongURL == longUrl).FirstOrDefault();
            return query1;
        }

        public ShortLink GetItemByShortUrl(string shortUrl)
        {
            ShortLink query2 = _context.ShortLinks.Find(shortUrl);
            return query2;
        }

        public ShortLink SaveItemToDataStore(ShortLink model)
        {
            try
            {
                model.Url = $"https://gj.al/{model.ShortURL}";
                _context.ShortLinks.Add(model);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }

            return model;
        }
    }
}
