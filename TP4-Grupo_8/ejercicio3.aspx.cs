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
        string consultaSQL = "SELECT IdTema FROM Libros GROUP BY IdTema";
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!Page.IsPostBack) 
            {
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

                SqlCommand cmd = new SqlCommand(consultaSQL, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                List<ListItem> items = new List<ListItem>();

                items.Add(new ListItem("-Seleccione un tema-", "0"));

                while (reader.Read())
                {
                    string idTema = reader["IdTema"].ToString();
                    items.Add(new ListItem("Tema " + idTema, idTema));
                }

                ddlTemas.DataSource = items;
                ddlTemas.DataTextField = "Text";
                ddlTemas.DataValueField = "Value";
                ddlTemas.DataBind();

                connection.Close();
            }
        }

        protected void linkVerTemas_Click(object sender, EventArgs e)
        {  
                string idTema = ddlTemas.SelectedValue;
                Server.Transfer("ListadoLibros.aspx");
        }
    }
}