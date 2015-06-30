using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Importaciones_RegistrarPaquete : System.Web.UI.Page
{
    string carpeta;
    WebService ws = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        carpeta = Path.Combine(Request.PhysicalApplicationPath, "Upload");
    }

    protected void txtcasilla_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Contratar_Click(object sender, EventArgs e)
    {
        if (!txtcasilla.Text.Equals("") && !txtcodpaquete.Text.Equals("") && !txtpeso.Text.Equals("") && !txtprecio.Text.Equals(""))
        {
            String dpi="";
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);

            SqlCommand CMD = new SqlCommand("SELECT * FROM Cliente WHERE casilla = " + txtcasilla.Text + ";", con);
            con.Open();
            SqlDataReader leer = CMD.ExecuteReader();
            if (leer.Read() == true)
            {
                dpi = leer["dpi"].ToString();
            }
            con.Close();

            WebService ws = new WebService();
            int codigopaquete = Int32.Parse(txtcodpaquete.Text);
            int peso = Int32.Parse(txtpeso.Text);
            int precio = Int32.Parse(txtprecio.Text);
            int clientedpi = Int32.Parse(dpi);
            String categoria = DropDownList2.Text;
            String codemp = Session["cod_empleado"].ToString();

            String response = ws.NuevoPaquete(codigopaquete, peso, precio, "Registrado en USA", clientedpi, codemp, categoria);
            if (response.Equals("OK"))
            {
                string message = "Paquete registrado exitosamente!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtcasilla.Text = ""; txtcodpaquete.Text = "";
                txtpeso.Text = ""; txtprecio.Text = "";
            }
            else
            {
                string message = "ERROR.. Esta paquete ya existe!";
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

                String response = ws.CargarCSV("Paquete", carpeta_final);
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

   