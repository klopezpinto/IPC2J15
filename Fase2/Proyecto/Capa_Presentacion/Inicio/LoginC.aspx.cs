using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio_Login : System.Web.UI.Page
{
    protected void Ingresar_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        
        String pass = txtpass.Text;
        String user = txtuser.Text;
        String response = ws.LoginCliente(user, pass);
        
        if (response.Equals("OK"))
        {
            Session["textboxValue"] = txtuser.Text;
            Response.Redirect("/Cliente/Cotizacion.aspx");            
        }           
        else
        {
            string message = "Nombre de usuario o contraseña incorrecta. Vuelve a intentar ingresar los datos.";
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

    protected void CuentaNueva_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearUsuario.aspx");
    }
}