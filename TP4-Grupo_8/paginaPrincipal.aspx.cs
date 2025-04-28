using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_8
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnEjercicio1_Click(object sender, EventArgs e)
        {
			Response.Redirect("ejercicio1.aspx");

        }

        protected void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio2.aspx");

        }

        protected void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio3.aspx");

        }
    }
}