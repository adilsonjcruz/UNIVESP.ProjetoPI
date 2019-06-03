using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UNIVESP.ProjetoPI.Web.Controllers
{
    public class PainelController : Controller
    {
        // GET: Painel
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}