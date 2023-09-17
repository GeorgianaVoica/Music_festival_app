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
    public partial class AddTicketForm : Form
    {
        private ITicketRepository _ticketRepository;
        public AddTicketForm()
        {
            InitializeComponent();
            this.CenterToParent();
            _ticketRepository = new TicketRepository();
            TypeComboBox.DataSource = Enum.GetValues(typeof(TicketType));
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var ticket = new Ticket();
            ticket.Id = Guid.NewGuid();
            ticket.Price = Convert.ToDouble(PriceTextbox.Text);
            ticket.Type = (TicketType)TypeComboBox.SelectedItem;
            _ticketRepository.Add(ticket);
            this.Hide();
        }
    }
}
