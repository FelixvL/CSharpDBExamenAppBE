using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    public class Antwoord
    {
        [Key]
        public int AntwoordId { get; set; }
        public string AntwoordTekst { get; set; }

        public virtual Vraag Vraag { get; set; }
        public virtual Poging Poging { get; set; }

    }
}
