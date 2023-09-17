using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    [Serializable]
    public class Playlist
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string SongLength { get; set; }
        public int ArtistId { get; set; }
    }
}
