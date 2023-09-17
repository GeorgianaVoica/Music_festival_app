using Proiect.Database;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        public void Add(Playlist song)
        {
             FakeDatabase.songs.Add(song);
        }

       

        public List<Playlist> GetSongs(int ArtistId)
        {
            return FakeDatabase.songs.Where(x => x.ArtistId == ArtistId).ToList();
        }

        public void Remove(Playlist song)
        {
            FakeDatabase.songs.Remove(song);
        }
    }
}
