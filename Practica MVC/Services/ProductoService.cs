using MongoDB.Driver;
using Practica_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_MVC.Services
{
    public class ProductoService : ConexionMongoDb
    {
        public List<Producto> GetProductos()
        {
            var productoConect = GetConexion().GetCollection<Producto>("productos");
            List<Producto> retorno = productoConect.Find(x => true).ToList();
            return retorno;    
        }

        public void InsertProducto(Producto entity)
        {
            var productoConect = GetConexion().GetCollection<Producto>("productos");
            productoConect.InsertOne(entity);
        }

        public void UpdateProducto(Producto entity)
        {
            var productoConect = GetConexion().GetCollection<Producto>("productos");
            productoConect.ReplaceOne(d => d.Id == entity.Id, entity);
        }
    }
}