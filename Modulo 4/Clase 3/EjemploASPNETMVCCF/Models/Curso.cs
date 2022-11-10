using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploASPNETMVCCF.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }

        public virtual Persona Persona { get; set; }

        public int AsignaturaId { get; set; }


        public Curso()
        {

        }
    }
}
