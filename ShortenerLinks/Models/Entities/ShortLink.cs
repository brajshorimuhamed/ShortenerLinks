using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities
{
    public class ShortLink
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string ShortURL { get; set; }

        public string LongURL { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
