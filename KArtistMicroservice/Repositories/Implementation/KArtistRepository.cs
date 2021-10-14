using Microsoft.EntityFrameworkCore;
using KArtistMicroservice.DbContexts;
using KArtistMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KArtistMicroservice.Repositories.Implementation
{
    public class KArtistRepository : IKArtistRepository
    {
        private readonly KArtistContext _dbContext;

        public KArtistRepository(KArtistContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<KArtist> GetKArtists()
        {
            return _dbContext.KArtists.ToList();
        }

        public KArtist GetKArtistById(int kArtistId)
        {
            return _dbContext.KArtists.Find(kArtistId);
        }

        public void AddKArtist(KArtist kArtist)
        {
            _dbContext.KArtists.Add(kArtist);
            SaveChanges();
        }

        public void UpdateKArtist(KArtist kArtist)
        {
            _dbContext.Entry(kArtist).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteKArtist(int kArtistId)
        {
            var kArtist = _dbContext.KArtists.Find(kArtistId);
            _dbContext.Remove(kArtist);
            SaveChanges();
        }

        private void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
