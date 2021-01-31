using quieropizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.Controllers
{
    public class productoController : Controller
    {
        // GET: producto
        public ActionResult Index()
        {
            var producto1 = new productomodel();
            producto1.Id = 1;
            producto1.Descripcion = "pizza 6 quesos";          
            var producto2 = new productomodel();
            producto2.Id = 2;
            producto2.Descripcion = "pizza 4 estaciones ";
            var producto3 = new productomodel();
            producto3.Id = 3;
            producto3.Descripcion = "pizza jamon y queso";
            var listadeProductos = new List<productomodel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        }
    }
}