using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AgregarCobro : System.Web.UI.Page
{
    WebService ws = new WebService();

    protected void Subir_Click(object sender, EventArgs e)
    {
        if (!txtcategoria.Text.Equals("") && !txtporcentaje.Text.Equals(""))
        {
            String categoria = txtcategoria.Text;
            int porcentaje = Int32.Parse(txtporcentaje.Text);

            String response = ws.AgregarImpuesto(categoria, porcentaje);
            if (!response.Equals("OK"))
            {
                string message = "Nuevo Impuesto agregado!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcategoria.Text = ""; txtporcentaje.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo agregar el impuesto.";
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

    protected void Subir0_Click(object sender, EventArgs e)
    {
        if (!txtpeso.Text.Equals(""))
        {
            int sucursal = Int32.Parse(DropDownList1.Text);
            int peso = Int32.Parse(txtpeso.Text);

            String response = ws.ModificarPeso(sucursal, peso);
            if (!response.Equals("OK"))
            {
                string message = "Nuevo Peso Agregado!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtpeso.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo agregar el peso.";
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

    protected void Subir1_Click(object sender, EventArgs e)
    {
        if (!txtcomision.Text.Equals(""))
        {
            int sucursal = Int32.Parse(DropDownList2.Text);
            int comision = Int32.Parse(txtcomision.Text);

            String response = ws.ModificarComision(sucursal, comision);
            if (!response.Equals("OK"))
            {
                string message = "Nueva Comision Agregada!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcomision.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo agregar la comision.";
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