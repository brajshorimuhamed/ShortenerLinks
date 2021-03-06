// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShortenerLinks.Models.Contexts;

namespace ShortenerLinks.Migrations
{
    [DbContext(typeof(ShortLinkDbContext))]
    partial class ShortLinkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShortenerLinks.Models.Entities.ShortLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("LongURL");

                    b.Property<string>("ShortURL");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("ShortLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
