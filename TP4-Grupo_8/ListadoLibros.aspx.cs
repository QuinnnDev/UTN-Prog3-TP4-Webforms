﻿using System;
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

            string conexion = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security = True;Encrypt=False";
            string tema = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;

            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();



            connection.Close();


        }
	}
}
