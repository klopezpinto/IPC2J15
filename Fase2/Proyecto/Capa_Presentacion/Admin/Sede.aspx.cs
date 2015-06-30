using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sede : System.Web.UI.Page
{
    WebService ws = new WebService();

    protected void Crear_Click(object sender, EventArgs e)
    {
        if (!txtcodsede.Text.Equals("") && !txtpais.Text.Equals(""))
        {
            int codsede = Int32.Parse(txtcodsede.Text);
            String pais = txtpais.Text;

            String response = ws.NuevaSede(codsede, pais);
            if (response.Equals("Agregado!"))
            {
                string message = "Nueva Sede creada exitosamente!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcodsede.Text = ""; txtpais.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo crear la nueva sede.";
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