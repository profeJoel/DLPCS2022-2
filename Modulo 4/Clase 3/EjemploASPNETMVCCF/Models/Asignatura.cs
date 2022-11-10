using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploASPNETMVCCF.Models
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        public Asignatura()
        {

        }
    }
}
