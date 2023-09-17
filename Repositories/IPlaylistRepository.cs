using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IPlaylistRepository
    {
        void Add(Playlist song);
        List<Playlist> GetSongs(int ArtistId);
        void Remove(Playlist song);
    }
}
