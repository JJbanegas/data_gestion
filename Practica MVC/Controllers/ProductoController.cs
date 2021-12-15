using Practica_MVC.Models;
using Practica_MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica_MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ListaProductos()
        {
            var productoService = new ProductoService();
            var model = productoService.GetProductos(); 
            return View(model);
        }

        //POST: Producto
        public ActionResult AgregarProducto(Producto model)
        {
            var productoService = new ProductoService();
            productoService.InsertProducto(model);
            return View("ListaProductos");
        } 
    }
}