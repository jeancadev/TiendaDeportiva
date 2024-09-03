// Estudiante.cs
using System.Collections.Generic;

namespace TiendaDeportiva.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Profesion { get; set; }
        public List<string> Deportes { get; set; }
        public List<string> Entretenimiento { get; set; }
        public List<string> Alimentacion { get; set; }
    }
}