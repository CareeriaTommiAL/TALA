using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TALA.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[ForeignKey("UserId")] //UserId FK Suoritusluokassa, lisäsin tämän notaation selvyyden vuoksi. FK toimisi myös ilman, pelkän ominaisuuden nimen perusteella.
        //public ICollection<Suoritus> Suoritukset { get; set; }
    }
}
