using PruebaWayni.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PruebaWayni.Controllers
{
    public class TB_TrabajadorController : Controller
    {



        EmpresaABCEntities1 db = new EmpresaABCEntities1();

        // GET: TB_Trabajador
        public ActionResult Index()
        {
           
            var list = db.TB_Trabajador.ToList();
            return View(list);
        }
    }
}