using KArtistMicroservice.Models;
using System.Collections.Generic;

namespace KArtistMicroservice.Services
{
    public interface IKArtistService
    {
        public IEnumerable<KArtist> GetKArtists();
        public KArtist GetKArtistById(int kArtistId);
        public void AddKArtist(KArtist kArtist);
        public void UpdateKArtist(KArtist kArtist);
        public void DeleteKArtist(int kArtistId);
    }
}
