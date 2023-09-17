using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public TicketType Type { get; set; }
    }
}
