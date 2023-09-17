using Proiect.Database;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public void Add(Ticket ticket)
        {
            FakeDatabase.tickets.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return FakeDatabase.tickets;
        }
    }
}
