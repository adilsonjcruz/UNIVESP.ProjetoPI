using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNIVESP.ProjetoPI.Web.Models
{
    public class Usuario
    {

        public int ID_Usuario { get; set; }
        public string Login_Usuario { get; set; }
        public string Nome_Usuario { get; set; }
        public string Senha_Usuario { get; set; }

        public Usuario(int ID_Usuario, string Login_Usuario, string Nome_Usuario, string Senha_Usuario) {

            this.ID_Usuario = ID_Usuario;
            this.Login_Usuario = Login_Usuario;
            this.Nome_Usuario = Nome_Usuario;
            this.Senha_Usuario = Senha_Usuario;

        }

    }
}