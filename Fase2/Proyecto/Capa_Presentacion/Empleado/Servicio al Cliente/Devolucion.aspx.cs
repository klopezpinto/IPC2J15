﻿using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Servicio_al_Cliente_Devolucion : System.Web.UI.Page
{
    protected void Guardar_Click(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);
        String codsuc = Session["sucursal"].ToString();
        int paquete = Int32.Parse(txtpaquete.Text);

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("SELECT A1.* FROM Paquete A1, LotePaquete A2 WHERE A2.Sucursal_cod_sucursal = " + codsuc + " AND A1.cod_paquete = " + paquete + "AND A1.estado = 'Entregado';", con);
        SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
        dataAdapt.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int codpaquete = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Session["ValorKey"] = codpaquete.ToString();

            if (!txtpaquete.Text.Equals(""))
            {
                WebService ws = new WebService();
                String codpaq = Session["ValorKey"].ToString();

                String response = ws.PaqueteDevolucion(codpaq);
                if (response.Equals("OK"))
                {
                    string message = "Devolucion exitosa!";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    GridView1.Dispose();
                    txtpaquete.Text = "";
                }
                else
                {
                    string message = "ERROR.. Este paquete no se puede devolver.";
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
            else
            {
                string message = "ERROR.. Debes de ingresar el numero de paquete.";
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
    }
}