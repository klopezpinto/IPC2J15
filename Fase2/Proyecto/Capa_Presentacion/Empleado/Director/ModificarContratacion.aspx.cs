using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Director_ModificarContratacion : System.Web.UI.Page
{
    protected void Label30_Init(object sender, EventArgs e)
    {
        txtcodigo.Text = Session["ValorKey"].ToString();

        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        String user = Session["ValorKey"].ToString();
        SqlCommand CMD = new SqlCommand("SELECT * FROM Usuario WHERE cod_usuario = " + Int32.Parse(txtcodigo.Text) + ";", con);
        con.Open();
        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtnombre.Text = leer["nombre"].ToString();
            txtapellido.Text = leer["apellido"].ToString();

        }
        con.Close();

        SqlCommand MCD = new SqlCommand("SELECT * FROM Empleado WHERE Usuario_cod_usuario = " + Int32.Parse(txtcodigo.Text) + ";", con);
        con.Open();
        SqlDataReader read = MCD.ExecuteReader();
        if (read.Read() == true)
        {
            txtsueldo.Text = read["sueldo"].ToString();
            txtpuesto.Text = read["puesto"].ToString();
            DropDownList1.Text = read["Sucursal_cod_sucursal"].ToString();
            DropDownList2.Text = read["Departamento_cod_departamento"].ToString();

        }
        con.Close();
    }
    protected void Crear_Click(object sender, EventArgs e)
    {
        if (!txtsueldo.Text.Equals("") && !txtpuesto.Text.Equals(""))
        {
            WebService ws = new WebService();

            int sueldo = Int32.Parse(txtsueldo.Text);
            String puesto = txtpuesto.Text;
            int sucursal = Int32.Parse(DropDownList1.Text);
            int departamento = Int32.Parse(DropDownList2.Text);
            int user = Int32.Parse(txtcodigo.Text);

            String response = ws.EditarDatosEmpleado(user, sueldo, puesto, sucursal, departamento);
            if (response.Equals("OK"))
            {
                string message = "Contratacion Modificada!";
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
                string message = "ERROR.. No se pudieron modificar los datos del empleado.";
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
            string message = "Se deben ingresa todos los datos.";
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