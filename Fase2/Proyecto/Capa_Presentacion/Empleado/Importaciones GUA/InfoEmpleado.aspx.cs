using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Importaciones_InfoEmpleado : System.Web.UI.Page
{
    protected void Label1_Init(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        String user = Session["cod_usuario"].ToString();

        SqlCommand CMD = new SqlCommand("SELECT * FROM Usuario WHERE cod_usuario = " + user + ";", con);
        con.Open();
        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtcodigo.Text = leer["cod_usuario"].ToString();
            txtcontraseña.Text = leer["pass"].ToString();
            txtnombre.Text = leer["nombre"].ToString();
            txtapellido.Text = leer["apellido"].ToString();
            txtdireccion.Text = leer["direccion"].ToString();
            txttelefono.Text = leer["telefono"].ToString();
        }
        con.Close();

        SqlCommand DCM = new SqlCommand("SELECT A1.nombre FROM Departamento A1, Usuario A2, Empleado A3 WHERE A2.cod_usuario = A3.Usuario_cod_usuario AND A3.Sucursal_cod_sucursal = A1.Sucursal_cod_sucursal AND A1.cod_departamento = A3.Departamento_cod_departamento AND cod_usuario = " + user + ";", con);
        con.Open();
        SqlDataReader look = DCM.ExecuteReader();
        if (look.Read() == true)
        {
            txtdepartamento.Text = look["nombre"].ToString();
        }
        con.Close();

        SqlCommand MCD = new SqlCommand("SELECT * FROM Empleado WHERE Usuario_cod_usuario = " + user + ";", con);
        con.Open();
        SqlDataReader read = MCD.ExecuteReader();
        if (read.Read() == true)
        {
            txtsucursal.Text = read["Sucursal_cod_sucursal"].ToString();
            Session["sucursal"] = txtsucursal.Text;
            String dep = read["Departamento_cod_Departamento"].ToString();
            Session["departamento"] = dep;
            String codemp = read["cod_empleado"].ToString();
            Session["cod_empleado"] = codemp;
        }
        con.Close();

        SqlCommand MC = new SqlCommand("SELECT A1.pais FROM Sede A1, Usuario A2, Empleado A3, Sucursal A4 WHERE A4.cod_sucursal = A3.Sucursal_cod_sucursal AND A3.Usuario_cod_usuario = A2.cod_usuario AND A4.Sede_cod_sede = A1.cod_sede AND A2.cod_usuario = " + user + ";", con);
        con.Open();
        SqlDataReader ja = MC.ExecuteReader();
        if (ja.Read() == true)
        {
            txtpais.Text = ja["pais"].ToString();
        }
        con.Close();
    }

    protected void Guardar_Click(object sender, EventArgs e)
    {
        if (!txtcontraseña.Text.Equals("") && !txtdireccion.Text.Equals("") && !txttelefono.Text.Equals(""))
        {
            WebService ws = new WebService();
            string contraseña = txtcontraseña.Text;
            string direccion = txtdireccion.Text;
            int telefono = Int32.Parse(txttelefono.Text);
            int user = Int32.Parse(txtcodigo.Text);

            String response = ws.EditarDirector(user, contraseña, direccion, telefono);
            if (!response.Equals("OK"))
            {
                string message = "Datos actualizados!";
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
                string message = "ERROR.. No se puedo actualizar la informacion.";
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