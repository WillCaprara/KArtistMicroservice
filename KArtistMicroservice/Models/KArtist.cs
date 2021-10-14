using System;
using KArtistMicroservice.Enums;

namespace KArtistMicroservice.Models
{
    public class KArtist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StageName { get; set; }
        public int AgencyId { get; set; }
        public ArtistType ArtistType { get; set; }
        public DateTime DebutDate { get; set; }
    }
}
