using KArtistMicroservice.Models;
using System.Collections.Generic;
using KArtistMicroservice.Repositories;

namespace KArtistMicroservice.Services.Implementation
{
    public class KArtistService : IKArtistService
    {
        private readonly IKArtistRepository _kArtistRepository;

        public KArtistService(IKArtistRepository kArtistRepository)
        {
            _kArtistRepository = kArtistRepository;
        }

        public IEnumerable<KArtist> GetKArtists()
        {
            var result = _kArtistRepository.GetKArtists();
            return result;
        }

        public KArtist GetKArtistById(int kArtistId)
        {
            var result = _kArtistRepository.GetKArtistById(kArtistId);
            return result;
        }

        public void AddKArtist(KArtist kArtist)
        {
            _kArtistRepository.AddKArtist(kArtist);
        }

        public void UpdateKArtist(KArtist kArtist)
        {
            _kArtistRepository.UpdateKArtist(kArtist);
        }

        public void DeleteKArtist(int kArtistId)
        {
            _kArtistRepository.DeleteKArtist(kArtistId);
        }
    }
}
