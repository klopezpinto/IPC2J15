using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Bodega_PaquetePerdido : System.Web.UI.Page
{
    string carpeta;

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

                WebService ws = new WebService();
                String response = ws.CargarCSV("PaquetePerdido", carpeta_final);
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

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int codusuario = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Session["ValorKey"] = codusuario.ToString();

            using (SqlConnection conn = new SqlConnection("Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;"))
            {
                conn.Open();

                string query = "INSERT INTO Paquete (cod_paquete, libras, precio, estado, Cliente_dpi, Empleado_cod_empleado, Impuesto_categoria) VALUES (@cod_paquete, @libras, @precio, @estado, @Cliente_dpi, @Empleado_cod_empleado, @Impuesto_categoria)";
                SqlCommand cmd = new SqlCommand(query, conn);

                foreach (GridViewRow row in GridView1.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cod_paquete", Convert.ToInt32(row.Cells[1].Text));
                    cmd.Parameters.AddWithValue("@libras", Convert.ToInt32(row.Cells[2].Text));
                    cmd.Parameters.AddWithValue("@precio", Convert.ToInt32(row.Cells[3].Text));
                    cmd.Parameters.AddWithValue("@estado", Convert.ToString(row.Cells[4].Text));
                    cmd.Parameters.AddWithValue("@Cliente_dpi", Convert.ToInt32(row.Cells[5].Text));
                    cmd.Parameters.AddWithValue("@Empleado_cod_empleado", Convert.ToInt32(row.Cells[6].Text));
                    cmd.Parameters.AddWithValue("@Impuesto_categoria", Convert.ToString(row.Cells[7].Text));

                    cmd.ExecuteNonQuery();
                }

            }
            
            WebService ws = new WebService();
            String codpaquete = Session["ValorKey"].ToString();

            String response = ws.PaquetePerdido(codpaquete);
            if (response.Equals("OK"))
            {
                string message = "Paquete reportado como Perdido.";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                GridView1.Dispose();
            }
            else
            {
                string message = "ERROR.. Este paquete no se puede reportar como perdido.";
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
    protected void Contratar_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();

        String response = ws.LimpiarTabla("PaquetePerdido");
        if (response.Equals("OK"))
        {
            string message = "Datos temporales eliminados Exitosamente!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            GridView1.Dispose();
        }
        else
        {
            string message = "ERROR.. No se pudieron eliminar los datos.";
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
    protected void Subir0_Click(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);
        int codlote = Int32.Parse(DropDownList3.Text);

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("SELECT * FROM PaquetePerdido WHERE NOT EXISTS (SELECT * FROM Paquete WHERE PaquetePerdido.cod_paquete=Paquete.cod_paquete) AND estado = 'Enviado por Lote " + codlote + "';", con);
        SqlDataAdapter dataAdapt = new SqlDataAdapter(cmd);
        dataAdapt.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
}