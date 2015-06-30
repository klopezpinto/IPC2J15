using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inicio_LoginE : System.Web.UI.Page
{
    protected void Ingresar_Click(object sender, EventArgs e)
    {
        {
            WebService ws = new WebService();

            String pass = txtpass.Text;
            int user = Int32.Parse(txtuser.Text);
            String response = ws.LoginEmpleado(user, pass);

            if (response.Equals("OK"))
            {
                String response1 = ws.VerDepartamento(user);
                if (response1.Equals("Bodega"))
                {
                    String response2 = ws.DirectorDep(user);
                    if (!response2.Equals("OK"))
                    {
                        Session["cod_usuario"] = txtuser.Text;
                        Response.Redirect("/Empleado/Director/InfoDirector.aspx");
                    }
                    else
                    {
                        Session["cod_usuario"] = txtuser.Text;
                        Response.Redirect("/Empleado/Bodega/InfoEmpleado.aspx");
                    }
                }
                else if (response1.Equals("Importaciones"))
                {
                    String response2 = ws.DirectorDep(user);
                    if (!response2.Equals("OK"))
                    {
                        Session["cod_usuario"] = txtuser.Text;
                        Response.Redirect("/Empleado/Director/InfoDirector.aspx");
                    }
                    else
                    {
                        String response3 = ws.Pais(user);
                        if (response3.Equals("Guatemala"))
                        {
                            Session["cod_usuario"] = txtuser.Text;
                            Response.Redirect("/Empleado/Importaciones GUA/InfoEmpleado.aspx");
                        }
                        else
                        {
                            Session["cod_usuario"] = txtuser.Text;
                            Response.Redirect("/Empleado/Importaciones USA/InfoEmpleado.aspx");
                        }
                    }
                }
                else if (response1.Equals("Servicio al Cliente"))
                {
                    String response2 = ws.DirectorDep(user);
                    if (!response2.Equals("OK"))
                    {
                        Session["cod_usuario"] = txtuser.Text;
                        Response.Redirect("/Empleado/Director/InfoDirector.aspx");
                    }
                    else
                    {
                        Session["cod_usuario"] = txtuser.Text;
                        Response.Redirect("/Empleado/Servicio al Cliente/InfoEmpleado.aspx");
                    }
                }
                else if (response1.Equals("Admin"))
                {
                    Response.Redirect("/Admin/CargaMasivaImpuestos.aspx");
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
    }
}
