using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4_Grupo_8
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                string stringConexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security = True;Encrypt=False";
                string tema = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;
                string consultaSql = "Select l.IdLibro, l.IdTema, l.Titulo, l.Precio, l.Precio FROM Libros l WHERE IdTema = " + tema;

                SqlConnection connection = new SqlConnection(stringConexion);
                connection.Open();

                SqlCommand command = new SqlCommand(consultaSql, connection);

                SqlDataReader reader = command.ExecuteReader();





                connection.Close();
            }


        }
	}
}
