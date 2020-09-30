using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExamenVragenAppDB
{
    public class DBExamContext : DbContext
    {
        public DbSet<Vraag> vragen { get; set; }
        public DbSet<Examen> examens { get; set; }
        public DbSet<Antwoord> antwoorden { get; set; }
        public DbSet<Poging> pogingen { get; set; }
        
    }
}
