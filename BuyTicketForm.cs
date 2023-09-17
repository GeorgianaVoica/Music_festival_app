using Proiect.Database;
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
    public partial class BuyTicketForm : Form
    {
        private ITicketRepository _ticketRepository;
        public BuyTicketForm()
        {
            InitializeComponent();
            this.CenterToParent();
            _ticketRepository = new TicketRepository();
            TicketDataGridView.AutoGenerateColumns = false;
            TicketDataGridView.AddColumn(0, "Price", "Price")
                               .AddColumn(1, "Type", "Type");
            TicketDataGridView.DataSource = _ticketRepository.GetTickets();
            Calculate();
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            var addTicketForm = new AddTicketForm();
            addTicketForm.ShowDialog();
            var data= _ticketRepository.GetTickets();
            TicketDataGridView.RefreshDataSource(data).Update();
            Calculate();
        }

        private void Calculate()
        {
            var total = 0.0;
            foreach(var v in FakeDatabase.tickets)
            {
                total += v.Price;
            }
            TotalLabel.Text = total.ToString();
        }
    }
}
