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
    public partial class EditStageForm : Form
    {
        private IStageRepository _stageRepository;
        private int _stageId;
        public EditStageForm(int Id)
        {
            InitializeComponent();
            this.CenterToParent();
            _stageRepository = new StageRepository();
            var entity = _stageRepository.GetById(Id);
            NametextBox.Text = entity.Name;
            LocationTextBox.Text = entity.Location;

            _stageId = Id;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var stage =  _stageRepository.GetById(_stageId);
            stage.Name = NametextBox.Text;
            stage.Location = LocationTextBox.Text;
            this.Hide();
        }
    }
}
