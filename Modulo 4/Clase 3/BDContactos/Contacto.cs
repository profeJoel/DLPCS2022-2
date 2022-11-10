using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDContactos
{
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactoId { get; set; }

        [Required]
        public string tipo { get; set; }

        [Required]
        public string valor { get; set; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]

        public virtual Persona Persona { get; set; }
    }
}
