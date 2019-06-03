using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UNIVESP.ProjetoPI.Web.Controllers
{
    public class LinksController : Controller
    {
        // GET: Link
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroLinks()
        {
            return View();
        }

    }
}