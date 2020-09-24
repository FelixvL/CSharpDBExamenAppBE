using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    public class Vraag
    {
        [Key]
        public int VraagID { get; set; }
        public string VraagTekst { get; set; }
        public string Antwoord { get; set; }
        public string Toelichting { get; set; }
        public string Zomaar { get; set; }
    }
}
