using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Importaciones_CrearLote : System.Web.UI.Page
{
    protected void Contratar_Click(object sender, EventArgs e)
    {
        if (!txtlote.Text.Equals(""))
        {
            WebService ws = new WebService();
            int codlote = Int32.Parse(txtlote.Text);
            int codsuc = Int32.Parse(Session["sucursal"].ToString());
            String response = ws.NuevoLote(codlote, codsuc);
            if (response.Equals("OK"))
            {
                string message = "Lote creado exitosamente!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtlote.Text = "";
                Response.Redirect("CrearLote.aspx");
            }
            else
            {
                string message = "ERROR.. Este lote ya existe.";
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
            string message = "Ingrese todos los datos que se le solicitan";
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