using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TCC_Dracoteca.Models
{
    [Table("livro")]
    public class Livro
    {
        [Key]
        [Column("tombo")]
        public int Tombo { get; set; }

        [Column("titulo")]
        public string Titulo { get; set; }

        [Column("autor")]
        public string Autor { get; set; }

        [Column("editora")]
        public string Editora { get; set; }

        [Column("ano")]
        public int Ano { get; set; }
    }
}
