using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALA.Server.Models
{
    public class Tehtava
    {
        public int TehtavaId { get; set; }
        public string Kuvaus { get; set; }
        
        public ICollection<Suoritus> Suoritukset { get; set; }
    }
}
