using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP4_Grupo_8
{
    public partial class ejercicio1 : System.Web.UI.Page
    {
        //private const string cadenaConexion = @" Data Source = DESKTOP - CCJO3LV\SQLEXPRESS; Initial Catalog = Neptuno; Integrated Security = True";
        string cadenaConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security = True";
        private string consultaSQL = "SELECT * FROM Provincias SELECT * FROM Localidades";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(consultaSQL, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                ddlProvinciaInicio.DataSource = sqlDataReader;
                ddlProvinciaInicio.DataTextField = "NombreProvincia";
                ddlProvinciaInicio.DataValueField = "IdProvincia";
                ddlProvinciaInicio.DataBind();
            }
        }
    }
}