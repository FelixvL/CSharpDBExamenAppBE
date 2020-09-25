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

        public Examen()
        {
            this.questions = new List<Vraag>();
        }
        public virtual List<Vraag> questions { get; set; }
      //  public virtual Vraag vraag { get; set; }


    }
}
