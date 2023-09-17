using Proiect.Entities;
using Proiect.Extensions;
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
    public partial class LineUpDetails : Form
    {
        private IPlaylistRepository _playlistRepository;
        private IArtistRepository _artistRepository;
        private int _artistId;
        public LineUpDetails(int ArtistId)
        {
            InitializeComponent();
            this.CenterToParent();
            _playlistRepository = new PlaylistRepository();
            _artistRepository = new ArtistRepository();
            var artist = _artistRepository.GetByArtistId(ArtistId);
            ArtistTextbox.Text = artist.Name;

            PlaylistDataGridView.AutoGenerateColumns = false;
            PlaylistDataGridView.AddColumn(0, "Song Name", "SongName")
                                .AddColumn(1, "Song Length", "SongLength")
                                .AddButtonColumn("deleteColumn", "Delete", string.Empty);

            PlaylistDataGridView.DataSource = _playlistRepository.GetSongs(ArtistId);
            _artistId = ArtistId;

        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSongForm(_artistId);
            addSongForm.ShowDialog();
            var data = _playlistRepository.GetSongs(_artistId);
            PlaylistDataGridView.RefreshDataSource(data).Update();
        }

        private void PlaylistDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == PlaylistDataGridView.Columns["deleteColumn"].Index)
            {
                var entity = PlaylistDataGridView.CurrentRow.DataBoundItem as Playlist;
                _playlistRepository.Remove(entity);
                var data = _playlistRepository.GetSongs(_artistId);
                PlaylistDataGridView.RefreshDataSource(data).Update();
            }
        }
    }
}
