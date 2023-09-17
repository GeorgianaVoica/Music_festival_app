using Proiect.Database;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        public void Add(Artist artist)
        {
            FakeDatabase.artists.Add(artist);

        }

        //public List<Artist> GetArtists()
        //{
        //    return FakeDatabase.artists;
        //}

        public List<Artist> GetArtists(int StageId)
        {
            return FakeDatabase.artists.Where(x=> x.StageId==StageId).ToList();
        }

        public Artist GetByArtistId(int ArtistId)
        {
            return FakeDatabase.artists.FirstOrDefault(x => x.Id == ArtistId);
        }
        public void Remove(Artist artist)
        {
            FakeDatabase.artists.Remove(artist);
        }
    }
}
