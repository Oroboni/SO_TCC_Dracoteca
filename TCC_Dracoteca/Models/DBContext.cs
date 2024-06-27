using System.Collections.Generic;
using System.Data.Entity;

namespace TCC_Dracoteca.Models
{
    public class LivroContext : DbContext
    {
        public LivroContext() : base("name=SomeeDbConnection")
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
