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
        public ActionResult AgregarProducto(Producto entity)
        {
            var productoService = new ProductoService();
            productoService.InsertProducto(entity);
            var model = productoService.GetProductos();
            return View("ListaProductos",model);
        } 

        //PUT: Producto
        public ActionResult ModificarProducto(Producto entity)
        {
            var productoService = new ProductoService();
            productoService.UpdateProducto(entity);
            var model = productoService.GetProductos();
            return View("ListaProductos", model);
        }

        public JsonResult Listar()
        {
            var productoService = new ProductoService();
            var model = productoService.GetProductos();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}