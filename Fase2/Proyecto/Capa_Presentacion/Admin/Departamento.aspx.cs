using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Departamento : System.Web.UI.Page
{
    WebService ws = new WebService();

    protected void Crear_Click(object sender, EventArgs e)
    {
        if (!txtcoddep.Text.Equals(""))
        {
            int coddep = Int32.Parse(txtcoddep.Text);
            String nombre = tipo.Text;
            int empleado = Int32.Parse(director.Text);
            int sucursal = Int32.Parse(suc.Text);

            String response = ws.DepSuc(nombre, sucursal);
            if (response.Equals("Agregado!"))
            {
                String response1 = ws.Director(empleado);
                if (response1.Equals("OK"))
                {
                    String response2 = ws.NuevoDepartamento(coddep, nombre, empleado, sucursal);
                    if (!response2.Equals("OK"))
                    {
                        string message = "Nuevo departamento creado Exitosamente!";
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        sb.Append("<script type = 'text/javascript'>");
                        sb.Append("window.onload=function(){");
                        sb.Append("alert('");
                        sb.Append(message);
                        sb.Append("')};");
                        sb.Append("</script>");
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                        txtcoddep.Text = "";
                    }
                    else
                    {
                        string message = "ERROR.. No se puedo crear el nuevo departamento.";
                        System.Text.StringBuilder sb = new System.Text.StringBuilder();
                        sb.Append("<script type = 'text/javascript'>");
                        sb.Append("window.onload=function(){");
                        sb.Append("alert('");
                        sb.Append(message);
                        sb.Append("')};");
                        sb.Append("</script>");
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                        txtcoddep.Text = "";
                    }
                }
                else
                {
                    string message = "ERROR.. El empleado ya es director de otro departamento.";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    txtcoddep.Text = "";
                }
            }
            else
            {
                string message = "ERROR.. Ya existe el departamento seleccionado en la sucursal.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcoddep.Text = "";
            }
        }
        else
        {
            string message = "ERROR.. Se deben de llenar todos los campos.";
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

