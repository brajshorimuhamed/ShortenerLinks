using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Entities
{
    public class ShortURLResponseModel
    {
        public string Message { get; set; }

        public bool Success { get; set; }

        public ShortLink Model { get; set; }
    }
}
