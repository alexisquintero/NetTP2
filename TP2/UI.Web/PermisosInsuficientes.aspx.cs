using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class PermisosInsuficientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbMenu.PostBackUrl = "~/Default.aspx";
            Response.AddHeader("REFRESH", "5;URL=Default.aspx");
        }
    }
}