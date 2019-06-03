using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNIVESP.ProjetoPI.Web.Models;

namespace UNIVESP.ProjetoPI.Web.Controllers
{
    public class PontoController : Controller
    {

       // [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

    }
}