using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Director_DespedirEmpleados : System.Web.UI.Page
{
    protected void Label30_Init(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        String user = Session["ValorKey"].ToString();

        SqlCommand CMD = new SqlCommand("SELECT * FROM Usuario WHERE cod_usuario = " + user + ";", con);
        con.Open();
        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtcodigo.Text = leer["cod_usuario"].ToString();
            txtnombre.Text = leer["nombre"].ToString();
            txtapellido.Text = leer["apellido"].ToString();
        }
        con.Close();
    }

    protected void Guardar_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        int user = Int32.Parse(txtcodigo.Text);

        String response = ws.EliminarEmpleado(user);
        if (response.Equals("OK"))
        {
            String response1 = ws.EliminarUsuario(user);
            if (response1.Equals("OK"))
            {
                string message = "Empleado Eliminado!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtapellido.Text = ""; txtcodigo.Text = ""; txtnombre.Text = "";
            }
            else
            {
                string message = "ERROR.. No se puedo eliminar al empleado.";
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
            string message = "ERROR.. No se puedo eliminar al empleado.";
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