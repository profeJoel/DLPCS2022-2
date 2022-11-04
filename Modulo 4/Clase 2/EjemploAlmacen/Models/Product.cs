namespace EjemploAlmacen.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SKU { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime Caducidad { get; set; }
    }
}
