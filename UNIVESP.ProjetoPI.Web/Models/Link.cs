using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIVESP.ProjetoPI.Web.Models
{
    public class Link
    {
        public int IdLink { get; set; }
        public int IdPonto { get; set; }
        public string LinkDirecionar { get; set; }
        public string Periodo { get; set; }
    }
}