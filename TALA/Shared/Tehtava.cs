﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALA.Shared
{
    public class Tehtava
    {
        public int TehtavaId { get; set; }
        public string Kuvaus { get; set; }
       
        public List<Suoritus> Suoritus { get; set; }
    }
}
