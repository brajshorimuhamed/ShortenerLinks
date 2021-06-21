using Microsoft.EntityFrameworkCore;
using ShortenerLinks.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortenerLinks.Models.Contexts
{
    public class ShortLinkDbContext : DbContext
    {
        public ShortLinkDbContext(DbContextOptions<ShortLinkDbContext> options) : base(options)
        {

        }

        public DbSet<ShortLink> ShortLinks { get; set; }
        
    }
}
