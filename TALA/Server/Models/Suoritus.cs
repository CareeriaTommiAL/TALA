using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALA.Server.Models

{
    public class Suoritus
    {
        public string UserId { get; set; }
        public int TehtavaId { get; set; }
        public int Suorituskerrat { get; set; }
        public Tehtava Tehtavat { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        
    }
}
