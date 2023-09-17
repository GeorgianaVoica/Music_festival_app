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
    public partial class AddStageForm : Form
    {
        private IStageRepository _stageRepository;
        public AddStageForm()
        {
            InitializeComponent();
            this.CenterToParent();
            _stageRepository = new StageRepository();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                Random random = new Random();
                var stage = new Stage();
                stage.Name = NameTextbox.Text;
                stage.Location = LocationTextBox.Text;
                stage.Id = random.Next(5, 100);

                _stageRepository.Add(stage);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
            this.Hide();
        }

        private bool FormIsValid()
        {
            if(!string.IsNullOrEmpty(errorProvider1.GetError(NameTextbox)))
            {
                return false;
            }
            if (!string.IsNullOrEmpty(errorProvider1.GetError(LocationTextBox)))
            {
                return false;
            }
            return true;
        }
        private void SetError(Control control)
        {
            errorProvider1.SetError(control, control.Text == string.Empty
              ? "Value should not be empty" : null);

        }

        private void NameTextbox_Validating(object sender, CancelEventArgs e)
        {
            SetError(NameTextbox);
        }

        private void LocationTextBox_Validating(object sender, CancelEventArgs e)
        {
            SetError(LocationTextBox);
        }
    }
}
