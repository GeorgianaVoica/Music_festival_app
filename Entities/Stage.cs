using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    [Serializable]
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Location { get; set; }
    }
}
