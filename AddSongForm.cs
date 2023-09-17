using Proiect.Entities;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class AddSongForm : Form
    {
        private IPlaylistRepository _playlistRepository;
        private int _artistId;
        public AddSongForm(int artistId)
        {
            InitializeComponent();
            this.CenterToParent();
            _artistId = artistId;
            _playlistRepository = new PlaylistRepository();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var song = new Playlist();
            song.ArtistId = _artistId;
            song.SongName = songNameTextbox.Text;
            song.SongLength = songLengthTextbox.Text;
            _playlistRepository.Add(song);
            this.Hide();
        }
    }
}
