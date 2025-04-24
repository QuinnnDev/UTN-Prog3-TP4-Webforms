using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_8
{
    public partial class ejercicio2 : System.Web.UI.Page
    {
        string conexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security = True;Encrypt=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();
        }
    }
}