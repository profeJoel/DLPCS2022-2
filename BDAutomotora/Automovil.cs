using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAutomotora
{
    public class Automovil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutomovilId { get; set; }
        public string Modelo { get; set; }

        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]

        public virtual Marca Marca { get; set; }

    }
}
