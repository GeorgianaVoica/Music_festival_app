using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface ITicketRepository
    {
        void Add(Ticket ticket);
        List<Ticket> GetTickets();
    }

}
