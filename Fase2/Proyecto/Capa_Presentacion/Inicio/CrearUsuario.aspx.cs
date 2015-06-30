using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Funciones;

public partial class Inicio_CrearUsuario : System.Web.UI.Page
{
    protected void Registrarse_Click(object sender, EventArgs e)
    {
        if (!txtapellido.Text.Equals("") && !txtcontraseña1.Text.Equals("") && !txtcontraseña2.Text.Equals("") && !txtcredito.Text.Equals("") && !txtdireccion.Text.Equals("") && !txtdpi.Text.Equals("") && !txtnombre.Text.Equals("") && !txttelefono.Text.Equals("") && !txtusuario.Text.Equals(""))
            {
            if (txtcontraseña1.Text.Equals(txtcontraseña2.Text))
            {
                WebService ws = new WebService();
                int dpi = Int32.Parse(txtdpi.Text);
                String usuario = txtusuario.Text;
                String pass = txtcontraseña1.Text;
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String direccion = txtdireccion.Text;
                int telefono = Int32.Parse(txttelefono.Text);
                int credito = Int32.Parse(txtcredito.Text);
                int sucursal = Int32.Parse(DropDownList1.Text);

                String response = ws.NuevoCliente(dpi, usuario, pass, nombre, apellido, "NULL", direccion, telefono, credito, sucursal);
                if (response.Equals("OK"))
                {
                    Response.Redirect("LoginC.aspx");
                }
                else
                {
                    string message = "ERROR.. Esta cuenta ya existe!";
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
                string message = "Contraseñas no coinciden. Ingresa una contraseña correcta.";
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
        else if (!txtapellido.Text.Equals("") && !txtcontraseña1.Text.Equals("") && !txtcontraseña2.Text.Equals("") && !txtcredito.Text.Equals("") && !txtdireccion.Text.Equals("") && !txtdpi.Text.Equals("") && !txtnombre.Text.Equals("") && !txttelefono.Text.Equals("") && !txtusuario.Text.Equals("") && !txtnit.Text.Equals(""))
        {
            if (txtcontraseña1.Text.Equals(txtcontraseña2.Text))
            {
                WebService ws = new WebService();
                int dpi = Int32.Parse(txtdpi.Text);
                String usuario = txtusuario.Text;
                String pass = txtcontraseña1.Text;
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String nit = txtnit.Text;
                String direccion = txtdireccion.Text;
                int telefono = Int32.Parse(txttelefono.Text);
                int credito = Int32.Parse(txtcredito.Text);
                int sucursal = Int32.Parse(DropDownList1.Text);

                String response = ws.NuevoCliente(dpi, usuario, pass, nombre, apellido, nit, direccion, telefono, credito, sucursal);
                if (response.Equals("OK"))
                {
                     Response.Redirect("LoginC.aspx");
                }
                else
                {
                    string message = "ERROR.. Esta cuenta ya existe!";
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
                string message = "Contraseñas no coinciden. Ingresa una contraseña correcta.";
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
            string message = "ERROR. Ingresa todos los datos requeridos.";
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