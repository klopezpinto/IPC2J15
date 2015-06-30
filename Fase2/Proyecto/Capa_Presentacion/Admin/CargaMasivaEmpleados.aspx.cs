using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CargaMasivaEmpleados : System.Web.UI.Page
{
    string carpeta;
    WebService ws = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        carpeta = Path.Combine(Request.PhysicalApplicationPath, "Upload");
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
            catch(Exception ex)
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