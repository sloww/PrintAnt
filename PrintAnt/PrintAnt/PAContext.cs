using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAnt
{
    class PAContext : DbContext
    {
        public PAContext()
            {
            }
        public DbSet<Model.DocTemplate> DocTemplates { get; set; }

    }
}
