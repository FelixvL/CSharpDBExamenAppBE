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
    }
}
