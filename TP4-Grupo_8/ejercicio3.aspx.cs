using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_8
{
    public partial class ejercicio3 : System.Web.UI.Page
    {
        string conexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security = True;Encrypt=False";
        string consultaSQL = "SELECT * FROM Libros";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

                SqlCommand cmd = new SqlCommand(consultaSQL, connection);
                SqlDataReader reader = cmd.ExecuteReader();


                connection.Close();
            }
        }
    }
}