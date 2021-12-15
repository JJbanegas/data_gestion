using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica_MVC.Services
{
    public class ConexionMongoDb
    {
        public IMongoDatabase GetConexion()
        {
            var cliente = new MongoClient("mongodb://localhost:27017");
            var db = cliente.GetDatabase("data_g");
            return db;
        }
    }
}