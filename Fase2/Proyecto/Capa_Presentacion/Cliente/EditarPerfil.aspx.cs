﻿using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_EditarPerfil : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Nombre.Text = Session["textboxValue"].ToString();
        

        
    }

    protected void Guardar_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        string direccion = txtdireccion.Text;
        int telefono = Int32.Parse(txttelefono.Text);
        int credito = Int32.Parse(txtcredito.Text);

        String response = ws.EditarDatosCliente(nombre, apellido, direccion, telefono, credito);
        if (response.Equals("OK"))
        {
            Response.Redirect("Cotizacion.aspx");
        }
        else
        {
            string message = "Se deben ingresa todos los datos.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);
        

        String user = Session["textboxValue"].ToString();
        String cadSql = "SELECT * FROM Cliente WHERE usuario = '" + user + "';";
        SqlCommand CMD = new SqlCommand(cadSql, con);
        con.Open();

        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtapellido.Text = leer["apellido"].ToString();
        }
        

    }
}