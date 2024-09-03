// Tienda.cs
namespace TiendaDeportiva.Models
{
    public class Tienda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CategoriaTienda Categoria { get; set; }
    }
}