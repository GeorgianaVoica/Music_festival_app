using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Database
{
    [Serializable]
    public static class FakeDatabase
    {
        public static List<Stage> stages = new List<Stage>()
        {
            new Stage()
        {
                Id = 0,
                Name = "Main Stage",
                Location = "Front"
            },
            new Stage()
        {
                Id = 1,
                Name = "The Ark Stage",
                Location = "Back"
            },
            new Stage()
        {
                Id = 2,
                Name = "DayDreaming Stage",
                Location = "Lateral1"
            }
    };

        public static List<Artist> artists = new List<Artist>()
    {
        new Artist()
        {
             Id = 100,
             Name = "HVNDS",
             Hour = "18:00",
             StageId = 0
        },
        new Artist()
        {
             Id = 101,
             Name = "Subcarpati",
             Hour = "19:00",
             StageId = 1
        },
        new Artist()
        {
             Id = 102,
             Name = "Firma",
             Hour = "21:00",
             StageId = 2
        }
    };

        public static List<Playlist> songs = new List<Playlist>()
        {
           new Playlist()
           {
               SongId=01,
               SongName = "You don't know",
               SongLength ="3 min",
               ArtistId=100
           },
            new Playlist()
           {
               SongId=02,
               SongName = "Da-i foale",
               SongLength ="4 min",
               ArtistId=101
           }
        };

        public static List<Ticket> tickets = new List<Ticket>();


    }

}


