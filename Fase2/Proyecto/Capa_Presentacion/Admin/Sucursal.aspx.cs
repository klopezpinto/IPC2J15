using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sucursal : System.Web.UI.Page
{
    WebService ws = new WebService();

    protected void Crear_Click(object sender, EventArgs e)
    {
        if (!txtcodsuc.Text.Equals("") && !txtcomision.Text.Equals("") && !txtdireccion.Text.Equals("") && !txtempleados.Text.Equals("") && !txtpeso.Text.Equals("") && !txttelefono.Text.Equals(""))
        {
            int codsuc = Int32.Parse(txtcodsuc.Text);
            String direccion = txtdireccion.Text;
            int telefono = Int32.Parse(txttelefono.Text);
            int capmax = Int32.Parse(txtempleados.Text);
            int comision = Int32.Parse(txtcomision.Text);
            int peso = Int32.Parse(txtpeso.Text);
            int codsede = Int32.Parse(DropDownList1.Text);

            String response = ws.NuevaSucursal(codsuc, direccion, telefono, capmax, comision, peso, codsede);
            if (!response.Equals("OK"))
            {
                string message = "Nueva sucursal creada Exitosamente!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcodsuc.Text = ""; txtdireccion.Text = ""; txttelefono.Text = ""; 
                txtempleados.Text = ""; txtcomision.Text = ""; txtpeso.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo crear la nueva sucursal.";
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