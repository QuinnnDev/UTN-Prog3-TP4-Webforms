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
        string cadenaConexion = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Viajes;Integrated Security = True";
        private string consultaSQL = "SELECT * FROM Provincias";
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
                ddlProvinciaInicio.Items.Insert(0, new ListItem("SELECCIONE PROVINCIA", "0"));

                sqlDataReader.Close();
                sqlDataReader = sqlCommand.ExecuteReader();

                ddlProvinciaFinal.DataSource = sqlDataReader;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();
                ddlProvinciaFinal.Items.Insert(0, new ListItem("SELECCIONE PROVINCIA", "0"));

                connection.Close();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProvinciaInicio.SelectedIndex != 0)
            {

                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();

                string provinciaSeleccionada = ddlProvinciaInicio.SelectedItem.Value;

                SqlCommand command = new SqlCommand("SELECT * FROM Localidades WHERE IdProvincia = " + provinciaSeleccionada, connection);

                SqlDataReader reader = command.ExecuteReader();

                ddlLocalidadInicio.DataSource = reader;
                ddlLocalidadInicio.DataTextField = "NombreLocalidad";
                ddlLocalidadInicio.DataValueField = "IdLocalidad";
                ddlLocalidadInicio.DataBind();
                ddlLocalidadInicio.Items.Insert(0, new ListItem("-- SELECCIONE LOCALIDAD --", "0"));



                connection.Close();
            }
            else
            {
                ddlLocalidadInicio.Items.Clear();
            }

            foreach (ListItem item in ddlProvinciaFinal.Items)
            {
                item.Enabled = !(ddlProvinciaInicio.SelectedValue != "0" && item.Value == ddlProvinciaInicio.SelectedValue);
            }
            if (ddlProvinciaFinal.SelectedValue == ddlProvinciaInicio.SelectedValue)
            {
                ddlProvinciaFinal.SelectedIndex = 0;
            }
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProvinciaFinal.SelectedIndex != 0)
            {

                SqlConnection connection = new SqlConnection(cadenaConexion);
                connection.Open();

                string provinciaSeleccionada = ddlProvinciaFinal.SelectedItem.Value;

                SqlCommand command = new SqlCommand("SELECT * FROM Localidades WHERE IdProvincia = " + provinciaSeleccionada, connection);

                SqlDataReader reader = command.ExecuteReader();

                ddlLocalidadFinal.DataSource = reader;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IdLocalidad";
                ddlLocalidadFinal.DataBind();
                ddlLocalidadFinal.Items.Insert(0, new ListItem("-- SELECCIONE LOCALIDAD --", "0"));

                

                connection.Close();
            }
            else
            {
                ddlLocalidadFinal.Items.Clear();
            }
        }
    }
}