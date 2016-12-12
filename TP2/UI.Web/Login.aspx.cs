using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using System.Web.Security;

namespace UI.Web
{
    public partial class Login : ApplicationForm
    {
        protected new void Page_Load(object sender, EventArgs e)
        {
       
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session["p"] = this.Ingresar();           
            Server.Transfer("~/Default.aspx", true);
        }
        public Business.Entities.Personas Ingresar()
        {
            Business.Entities.Personas p = new UsuarioLogic().Ingresar(txtUsuario.Text, txtContrasenia.Text);
            if (p == null)
            {
                Page.Response.Write("Usuario o contraseña incorrectos");
                return null;
            }
            return p;
        }
    }
}