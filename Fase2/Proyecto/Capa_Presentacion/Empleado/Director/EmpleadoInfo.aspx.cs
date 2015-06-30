using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Director_EmpleadoInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
            txtcontraseña.Text = leer["pass"].ToString();
            txtnombre.Text = leer["nombre"].ToString();
            txtapellido.Text = leer["apellido"].ToString();
            txtdireccion.Text = leer["direccion"].ToString();
            txttelefono.Text = leer["telefono"].ToString();
        }
        con.Close();
    }
}