﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TALA.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Suoritus> Suoritukset { get; set; }
    }
}
