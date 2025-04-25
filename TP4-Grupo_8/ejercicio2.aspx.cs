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
        string consultaSQL = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
        private void CargarTabla(string consultaSQL)
        {
            try
            {
                lblMensaje.Text = "";

                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

                SqlCommand cmd = new SqlCommand(consultaSQL, connection);
                SqlDataReader reader = cmd.ExecuteReader();


                gvTablaProductos.DataSource = reader;
                gvTablaProductos.DataBind();



                connection.Close();

            }
            catch (Exception)
            {

                lblMensaje.Text = "Ocurrio un error inesperado </br> No se pudo cargar la tabla correctamente";
                gvTablaProductos.DataSource = null;
                gvTablaProductos.DataBind();
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarTabla(consultaSQL);
            }

        }

        protected void BtnQuitar_Click(object sender, EventArgs e)
        {
            // string ConsultaSql = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";

            CargarTabla(consultaSQL);
            TxtCategoria.Text = "";
            TxtProducto.Text = "";
        }

        // Este es posiblemente el peor código que leí en mi vida
        // Si, confirmo.
        //protected void BtnFiltrar_Click(object sender, EventArgs e)
        //{
        //    string ConsultaSql = "SELECT * FROM Productos";
        //    string tipoFiltroProducto = DdlProducto.SelectedValue;
        //    string tipoFiltroCategoria = DdlCategoria.SelectedValue;

        //    if (TxtCategoria.Text != string.Empty && TxtProducto.Text != string.Empty && tipoFiltroCategoria == "=" && tipoFiltroProducto == "=")
        //    {
        //        ConsultaSql += " WHERE IdProducto = " + TxtProducto.Text + " AND IdCategoría = " + TxtCategoria.Text;
        //        CargarTabla(ConsultaSql);
        //    }
        //    else
        //    {
        //        if (TxtProducto.Text != string.Empty && tipoFiltroProducto == "=")
        //        {
        //        condiciones.Add($"IdCategoría {operadorCategoria} {filtroCategoria}");
        //        }
        //    }
        //    if(TxtCategoria.Text != string.Empty && TxtProducto.Text != string.Empty && tipoFiltroCategoria == ">" && tipoFiltroProducto == ">")
        //    {
        //        ConsultaSql += " WHERE IdProducto > " + TxtProducto.Text + " AND IdCategoría >" + TxtCategoria.Text;
        //        CargarTabla(ConsultaSql);

        //    }
        //    else
        //    {
        //        if (TxtProducto.Text != string.Empty && TxtCategoria.Text == string.Empty && tipoFiltroProducto == ">")
        //        {
        //            ConsultaSql += " WHERE IdProducto > " + TxtProducto.Text;
        //            CargarTabla(ConsultaSql);
        //        }

        //        if (TxtCategoria.Text != string.Empty && TxtProducto.Text == string.Empty && tipoFiltroCategoria == ">")
        //        {
        //            ConsultaSql += " WHERE IdCategoría > " + TxtCategoria.Text;
        //            CargarTabla(ConsultaSql);
        //        }
        //    }
        //}

        protected void BtnFiltrar_Click(object sender, EventArgs e)
        {
            //string ConsultaSql = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";

            string filtroProducto = TxtProducto.Text;
            string filtroCategoria = TxtCategoria.Text;

            string tipoFiltroProducto = DdlProducto.SelectedValue;
            string tipoFiltroCategoria = DdlCategoria.SelectedValue;

            List<string> condicion = new List<string>();

            if (!string.IsNullOrEmpty(filtroProducto))
            {
                condicion.Add($"IdProducto {tipoFiltroProducto} {filtroProducto}");
            }

            if (!string.IsNullOrEmpty(filtroCategoria))
            {
                condicion.Add($"IdCategoría {tipoFiltroCategoria} {filtroCategoria}");
            }

            if (condicion.Count > 0)
            {
                consultaSQL += " WHERE " + string.Join(" AND ", condicion);
            }

            CargarTabla(consultaSQL);

            TxtProducto.Text = string.Empty;
            TxtCategoria.Text = string.Empty;

        }

        protected void TxtProducto_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}