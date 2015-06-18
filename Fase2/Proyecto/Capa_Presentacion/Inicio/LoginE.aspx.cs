using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        int codigo = Int32.Parse(txtuser.Text);

        String response = ws.LoginEmpleado(codigo);
        if (response.Equals("OK!"))
        {
            Response.Redirect("/Empleado/Otors.aspx");
            txtuser.Text = ""; 
        }
        else
        {
            string message = "Codigo incorrecto. Vuelve a intentar ingresar el codigo.";
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