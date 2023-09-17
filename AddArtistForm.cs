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
    public partial class AddArtistForm : Form
    {
        private IArtistRepository _artistRepository;
        private int _stageId;
        public AddArtistForm(int stageId)
        {
            InitializeComponent();
            this.CenterToParent();
            _stageId = stageId;
            _artistRepository = new ArtistRepository();

           
        }

        private void SaveArtistButton_Click(object sender, EventArgs e)
        {
            var artist = new Artist();
            artist.StageId = _stageId;
            artist.Name = NameTextbox.Text;
            artist.Hour = HourTextbox.Text;
            _artistRepository.Add(artist);
            this.Hide();
        }
    }
}
