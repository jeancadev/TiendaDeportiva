using Microsoft.AspNetCore.Mvc;
using TiendaDeportiva.Models;
using System.Collections.Generic;

namespace TiendaDeportiva.Controllers
{
    public class HomeController : Controller
    {
        private static List<Tienda> tiendas = new List<Tienda>
        {
            // Categoría VIP
            new Tienda { Id = 1, Nombre = "Adidas", Categoria = CategoriaTienda.VIP },
            new Tienda { Id = 2, Nombre = "Nike", Categoria = CategoriaTienda.VIP },
            new Tienda { Id = 3, Nombre = "Puma", Categoria = CategoriaTienda.VIP },

            // Categoría Alta
            new Tienda { Id = 4, Nombre = "Under Armour", Categoria = CategoriaTienda.Alta },
            new Tienda { Id = 5, Nombre = "Reebok", Categoria = CategoriaTienda.Alta },
            new Tienda { Id = 6, Nombre = "New Balance", Categoria = CategoriaTienda.Alta },

            // Categoría Media
            new Tienda { Id = 7, Nombre = "Asics", Categoria = CategoriaTienda.Media },
            new Tienda { Id = 8, Nombre = "Fila", Categoria = CategoriaTienda.Media },
            new Tienda { Id = 9, Nombre = "Skechers", Categoria = CategoriaTienda.Media },

            // Categoría Baja
            new Tienda { Id = 10, Nombre = "Decathlon", Categoria = CategoriaTienda.Baja },
            new Tienda { Id = 11, Nombre = "Sprinter", Categoria = CategoriaTienda.Baja },
            new Tienda { Id = 12, Nombre = "Sports Direct", Categoria = CategoriaTienda.Baja },

            // Sin Clasificar
            new Tienda { Id = 13, Nombre = "Local Sports Shop", Categoria = CategoriaTienda.SinClasificar },
            new Tienda { Id = 14, Nombre = "New Sports Brand", Categoria = CategoriaTienda.SinClasificar },
            new Tienda { Id = 15, Nombre = "Upcoming Athletics", Categoria = CategoriaTienda.SinClasificar }
        };

        private static Estudiante estudiante = new Estudiante
        {
            Id = 1,
            Nombre = "Ignacio",
            Apellido = "Robles",
            Edad = 22,
            Profesion = "Estudiante de Ingenieria",
            Deportes = new List<string> { "Futbol", "Baloncesto", "Beisbol" },
            Entretenimiento = new List<string> { "Videojuegos", "Cine", "Lectura" },
            Alimentacion = new List<string> { "Comida saludable", "Proteinas", "Frutas" }
        };

        public IActionResult Index()
        {
            return View(estudiante);
        }

        public IActionResult Categoria(CategoriaTienda categoria)
        {
            var tiendasCategoria = tiendas.FindAll(t => t.Categoria == categoria);
            ViewBag.Categoria = categoria;
            return View(tiendasCategoria);
        }

        public IActionResult Informacion()
        {
            return View();
        }
    }
}