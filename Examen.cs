using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    public class Examen
    {
        [Key]
        public int ExamenId { get; set; }
        public string naam { get; set; }
        public virtual List<Vraag> vragen { get; set; }

    }
}
