using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Director_ContratarEmpleados : System.Web.UI.Page
{
    string carpeta;
    WebService ws = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        carpeta = Path.Combine(Request.PhysicalApplicationPath, "Upload");
    }

    protected void Contratar_Click(object sender, EventArgs e)
    {
        String sucursal = Session["sucursal"].ToString();

        WebService ws = new WebService();
        String noempleados = ws.NumeroEmpleados(sucursal);
        String maxnoempleados = ws.MaxNumeroEmpleados(sucursal);

        int ne = Int32.Parse(noempleados);
        int ma = Int32.Parse(maxnoempleados);

        if (ne < ma)
        {
            if (!txtapellido.Text.Equals("") && !txtcodigoempleado.Text.Equals("") && !txtcodigousuario.Text.Equals("") && !txtdireccion.Text.Equals("") && !txtnombre.Text.Equals("") && !txtsueldo.Text.Equals("") && !txttelefono.Text.Equals(""))
            {
                int codigousuario = Int32.Parse(txtcodigousuario.Text);
                int codigoempleado = Int32.Parse(txtcodigoempleado.Text);
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String direccion = txtdireccion.Text;
                int telefono = Int32.Parse(txttelefono.Text);
                int sueldo = Int32.Parse(txtsueldo.Text);
                String dep = Session["departamento"].ToString();

                String response = ws.NuevoEmpleado(codigousuario, codigoempleado, nombre, apellido, direccion, telefono, sueldo, sucursal, dep);
                if (response.Equals("OK"))
                {
                    string message = "Empleado contratado exitosamente!";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    txtapellido.Text = ""; txtcodigoempleado.Text = ""; txtcodigousuario.Text = "";
                    txtdireccion.Text = ""; txtnombre.Text = ""; txtsueldo.Text = ""; txttelefono.Text = "";
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
        else
        {
            string message = "ERROR.. Ya no existe una vacante para el empleado en esta sucursal.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            txtapellido.Text = ""; txtcodigoempleado.Text = ""; txtcodigousuario.Text = "";
            txtdireccion.Text = ""; txtnombre.Text = ""; txtsueldo.Text = ""; txttelefono.Text = "";
        }
    }

    protected void Subir_Click(object sender, EventArgs e)
    {
        if (FileUpload1.PostedFile.FileName == "")
        {
            string message = "ERROR.. No seleccionaste ningun archivo";
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
            string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
            switch (extension.ToLower())
            {
                case ".csv":
                    break;

                default:
                    string message = "ERROR.. La extension no es valida.";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    return;
            }
            try
            {
                string archivo = Path.GetFileName(FileUpload1.PostedFile.FileName);
                string carpeta_final = Path.Combine(carpeta, archivo);
                FileUpload1.PostedFile.SaveAs(carpeta_final);

                String response = ws.CargarCSV("Usuario", carpeta_final);
                if (response.Equals("OK"))
                {
                    string message = "ERROR.";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    return;
                }
                else
                {
                    string message = "Archivo subido correctamente.";
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
            catch (Exception ex)
            {
                string message = "ERROR.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                return;
            }
        }
    }
    protected void Cargar_Click(object sender, EventArgs e)
    {
        if (FileUpload2.PostedFile.FileName == "")
        {
            string message = "ERROR.. No seleccionaste ningun archivo";
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
            string extension = Path.GetExtension(FileUpload2.PostedFile.FileName);
            switch (extension.ToLower())
            {
                case ".csv":
                    break;

                default:
                    string message = "ERROR.. La extension no es valida.";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    return;
            }
            try
            {
                string archivo = Path.GetFileName(FileUpload2.PostedFile.FileName);
                string carpeta_final = Path.Combine(carpeta, archivo);
                FileUpload2.PostedFile.SaveAs(carpeta_final);

                String response = ws.CargarCSV("Empleado", carpeta_final);
                if (response.Equals("OK"))
                {
                    string message = "ERROR.";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                    return;
                }
                else
                {
                    string message = "Archivo subido correctamente.";
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
            catch (Exception ex)
            {
                string message = "ERROR.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                return;
            }

        }
    }

}