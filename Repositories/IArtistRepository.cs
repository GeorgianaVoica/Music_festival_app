using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IArtistRepository
    {
        void Add(Artist artist);
        List<Artist> GetArtists(int StageId);
        Artist GetByArtistId(int ArtistId);
        void Remove(Artist artist);
    }
}
