namespace ejemploASPMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Address { get; set; }
    }
}
