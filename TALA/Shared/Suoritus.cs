using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALA.Shared
{
    public class Suoritus
    {
        public int SuoritusId { get; set; }
        public string UserId { get; set; }
        public int TehtavaId { get; set; }
        public DateTime Suoritusaika { get; set; }
        public Tehtava Tehtava { get; set; }

    }
}
