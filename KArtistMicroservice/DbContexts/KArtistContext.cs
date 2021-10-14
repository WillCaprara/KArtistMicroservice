using KArtistMicroservice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KArtistMicroservice.DbContexts
{
    public class KArtistContext: DbContext
    {
        public KArtistContext(DbContextOptions<KArtistContext> options): base(options)
        {

        }

        public DbSet<KArtist> KArtists { get; set; }
        public DbSet<Agency> Agencies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agency>().HasData(
                new Agency
                {
                    Id = 1,
                    Name = "EDAM Entertainment"
                }
            );
        }
    }
}
