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
        
        private void CargarTabla(string consultaSQL = "SELECT * FROM Productos")
        {
            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();

            SqlCommand cmd = new SqlCommand(consultaSQL, connection);
            SqlDataReader reader = cmd.ExecuteReader();


            gvTablaProductos.DataSource = reader;
            gvTablaProductos.DataBind();



            connection.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargarTabla();
            }

        }

        protected void BtnQuitar_Click(object sender, EventArgs e)
        {

        }

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string ConsultaSql = "SELECT * FROM Productos";
            if (TxtProducto.Text != string.Empty) 
            {
                ConsultaSql += " WHERE IdProducto = "+ TxtProducto.Text;
                CargarTabla(ConsultaSql);
            }
        }

        protected void TxtProducto_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}