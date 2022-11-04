using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public virtual Autor Autor { get; set; }
    }
}
