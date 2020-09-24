using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    [Table("ExamenVragenMany")]
    public class ExamenVragenMany
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int ExamenID { get; set; }

        [ForeignKey("ExamenID ")]
        public Examen examen { get; set; }

        [Required]
        public int VraagID { get; set; }

        [ForeignKey("VraagID")]
        public Vraag vraag { get; set; }
    }
}
