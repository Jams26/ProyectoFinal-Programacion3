using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Utilidades;

namespace TiendaOnline.Areas.Cliente.Controllers
{
    [Area("Cliente")]

    public class OrdenController : Controller
    {

        ApplicationDbContext _db;

        public OrdenController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Checkout Action Method

        public IActionResult Checkout()
        {
            return View();
        }

        //Post Checkout
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Checkout(Orden unaOrden)
        {

            List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos != null)
            {
                foreach(var producto in productos)
                {
                    OrdenDetalles ordenDetalles = new OrdenDetalles();
                    ordenDetalles.ProductoID = producto.ID;
                    unaOrden.OrdenDetalles.Add(ordenDetalles);
                }
            }

            unaOrden.numeroOrden = obtenerNumeroOrden();
            _db.Orden.Add(unaOrden);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("productos", new List<Productos>());

            return View();
        }

        public string obtenerNumeroOrden()
        {
            int conteoFila = _db.Orden.ToList().Count()+1;
            return conteoFila.ToString("000");
        }

    }
}