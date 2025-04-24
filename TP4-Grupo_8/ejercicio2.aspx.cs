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

            string consultaSQL = "SELECT * FROM Productos";

            if (!Page.IsPostBack)
            {
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

                SqlCommand cmd = new SqlCommand(consultaSQL, connection);
                SqlDataReader reader = cmd.ExecuteReader();


                gvTablaProductos.DataSource = reader;
                gvTablaProductos.DataBind();



                connection.Close();

            }

        }
    }
}