using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    public class Poging
    {
        [Key]
        public int PogingId { get; set; }

        public virtual Examen Examen { get; set; }
    }
}
