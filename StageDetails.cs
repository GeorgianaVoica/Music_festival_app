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
    public partial class StageDetails : Form
    {
        private IStageRepository _stageRepository;
        private IArtistRepository _artistRepository;
        private int _stageId;
        public StageDetails(int Id)
        {
            InitializeComponent();
            this.CenterToParent();
            _stageRepository = new StageRepository();
            _artistRepository = new ArtistRepository();
            var stage = _stageRepository.GetById(Id);
            stageNameTextbox.Text = stage.Name;

            artistsDataGridView.AutoGenerateColumns = false;
            artistsDataGridView.AddColumn(0, "Name", "Name")
                .AddColumn(1, "Hour", "Hour")
                .AddButtonColumn("playlistColumn", "See Playlist", "Playlist")
                .AddButtonColumn("deleteColumn", "Delete", string.Empty);

            artistsDataGridView.DataSource = _artistRepository.GetArtists(Id);
            _stageId = Id;
        }

        private void AddArtistButton_Click(object sender, EventArgs e)
        {
            var addArtist = new AddArtistForm(_stageId);
            addArtist.ShowDialog();
            var data = _artistRepository.GetArtists(_stageId);
            artistsDataGridView.RefreshDataSource(data);
        }

        private void artistsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == artistsDataGridView.Columns["playlistColumn"].Index)
            {
                var entity = artistsDataGridView.CurrentRow.DataBoundItem as Artist;
                var song = new LineUpDetails(entity.Id);
                song.ShowDialog();
            }
          
            if (e.ColumnIndex == artistsDataGridView.Columns["deleteColumn"].Index)
            {
                var entity = artistsDataGridView.CurrentRow.DataBoundItem as Artist;
                _artistRepository.
                    Remove(entity);
                var data = _artistRepository.GetArtists(_stageId);
                artistsDataGridView.RefreshDataSource(data).Update();
            }
        }
    }
}
