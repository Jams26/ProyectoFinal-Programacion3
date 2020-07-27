using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Models;
using TiendaOnline.Utilidades;
using X.PagedList;

namespace TiendaOnline.Controllers
{

    [Area("Cliente")]

    public class HomeController : Controller
    {

        private ApplicationDbContext _db;

        public HomeController (ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int? page)
        {
            return View(_db.Productos.Include(c=>c.CategoriaProductos).ToList().ToPagedList(page??1, 6));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //Detalles de Producto

        public ActionResult Detail(int? id)
        {

            if(id == null)
            {
                return NotFound();
            }

            var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }


        //Post Detalles de Producto
        [HttpPost]
        [ActionName("Detail")]
        public ActionResult ProductoDetail(int? id)
        {

            List<Productos> productos = new List<Productos>();

            if (id == null)
            {
                return NotFound();
            }

            var producto = _db.Productos.Include(c => c.CategoriaProductos).FirstOrDefault(c => c.ID == id);

            if (producto == null)
            {
                return NotFound();
            }


            productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos == null)
            {
                productos = new List<Productos>();
            }
            productos.Add(producto);
            HttpContext.Session.Set("productos", productos);
            return RedirectToAction(nameof(Index));
        }

        //Get Remove
        [ActionName("Remove")]
        public IActionResult RemoveDelCarrito(int? id)
        {

            List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos != null)
            {
                var producto = productos.FirstOrDefault(c => c.ID == id);
                if (producto != null)
                {
                    productos.Remove(producto);
                    HttpContext.Session.Set("productos", productos);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Remove(int? id)
        {

            List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos != null)
            {
                var producto = productos.FirstOrDefault(c => c.ID == id);
                if (producto != null)
                {
                    productos.Remove(producto);
                    HttpContext.Session.Set("productos", productos);
                }
            }
            return RedirectToAction(nameof(Index));
        }


        //Producto Carrito

        public IActionResult Carrito()
        {
            List<Productos> productos = HttpContext.Session.Get<List<Productos>>("productos");
            if (productos == null)
            {
                productos = new List<Productos>();
            }
            return View(productos);
        }

    }
}
