using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Servicio_al_Cliente_BusquedaClientes : System.Web.UI.Page
{
    protected void Buscar_Click(object sender, EventArgs e)
    {
        if (!txtapellido.Text.Equals("") && !txtnombre.Text.Equals(""))
        {
            WebService ws = new WebService();
            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;

            String response = ws.BusquedaCasilla(nombre, apellido);
            
            if (response.Equals("ERROR"))
            {
                string message = "ERROR.. El cliente no existe o no tiene una casilla disponible.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
            else
            {
                string message = "Casilla encontrada con exito!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                casilla.Text = response;
            }
        }
        else
        {
            string message = "ERROR.. Debes de ingresar el numero de casilla.";
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