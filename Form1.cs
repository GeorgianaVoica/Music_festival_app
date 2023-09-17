using Proiect.Database;
using Proiect.Entities;
using Proiect.Extensions;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        private IStageRepository _stageRepository;
        private ITicketRepository _ticketRepository;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            _stageRepository = new StageRepository();
            _ticketRepository = new TicketRepository();
            StageDataGridView.AutoGenerateColumns = false;

            StageDataGridView.AddColumn(0, "Name", "Name")
                             .AddColumn(1, "Location", "Location")
                             .AddButtonColumn("ArtistsColumn", "See Artists", "Artists")
                             .AddButtonColumn("editColumn", "Edit", string.Empty)
                             .AddButtonColumn("deleteColumn", "Delete", string.Empty);
                             
            StageDataGridView.DataSource = _stageRepository.GetAll();
           
        }

        private void AddStageButton_Click(object sender, EventArgs e)
        {
            var addStage = new AddStageForm();
            addStage.ShowDialog();

            var data = _stageRepository.GetAll();
            StageDataGridView.RefreshDataSource(data).Update();
        }

        private void StageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == StageDataGridView.Columns["ArtistsColumn"].Index)
            {
                var currentOb = (Stage)StageDataGridView.CurrentRow.DataBoundItem;
                var artist = new StageDetails(currentOb.Id);
                artist.ShowDialog();


            }
            if(e.ColumnIndex ==StageDataGridView.Columns["editColumn"].Index)
            {
                var entity = StageDataGridView.CurrentRow.DataBoundItem as Stage;
                var editStage = new EditStageForm(entity.Id);
                editStage.ShowDialog();

                var data = _stageRepository.GetAll();
                StageDataGridView.RefreshDataSource(data).Update();
            }
           if(e.ColumnIndex==StageDataGridView.Columns["deleteColumn"].Index)
            {
                var entity = StageDataGridView.CurrentRow.DataBoundItem as Stage;
                _stageRepository.GetAll().Remove(entity);
                var data = _stageRepository.GetAll();
                StageDataGridView.RefreshDataSource(data).Update();
            }
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            var buyTicketForm = new BuyTicketForm();
            buyTicketForm.ShowDialog();
            
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "BinaryFile|.bin";
            dlg.ShowDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(dlg.FileName))
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, FakeDatabase.stages);
                    fs.Close();
                    StageDataGridView.DataSource = null;
                }
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BynaryFile|.bin";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(dlg.FileName))
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    FakeDatabase.stages = (List<Stage>)bf.Deserialize(fs) as List<Stage>;
                    fs.Close();
                    StageDataGridView.DataSource = FakeDatabase.stages;
                }
            }
        }
    }
}
