using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_EditarPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Nombre.Text = Session["textboxValue"].ToString();
    }

    protected void Label30_Init(object sender, EventArgs e)
    {
        int cod = 0;
        String user = Session["textboxValue"].ToString();

        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        SqlCommand CMD = new SqlCommand("SELECT * FROM Usuario WHERE usuario = '" + user + "';", con);
        con.Open();
        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtnombre.Text = leer["nombre"].ToString();
            txtapellido.Text = leer["apellido"].ToString();
            txtdireccion.Text = leer["direccion"].ToString();
            txttelefono.Text = leer["telefono"].ToString();
            Label31.Text = leer["cod_usuario"].ToString();
            cod = Int32.Parse(Label31.Text);
        }
        con.Close();

        SqlCommand MCD = new SqlCommand("SELECT * FROM Cliente WHERE Usuario_cod_usuario = " + cod + ";", con);
        con.Open();
        SqlDataReader read = MCD.ExecuteReader();
        if (read.Read() == true)
        {
            txtcredito.Text = read["tarjeta_credito"].ToString();
            String dpi = read["dpi"].ToString();
            Session["dpi"] = dpi;
        }
        con.Close();
    }

    protected void Guardar_Click(object sender, EventArgs e)
    {
        WebService ws = new WebService();
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        string direccion = txtdireccion.Text;
        int telefono = Int32.Parse(txttelefono.Text);
        int credito = Int32.Parse(txtcredito.Text);
        int cod = Int32.Parse(Label31.Text);
        String user = Nombre.Text;

        if (!txtapellido.Text.Equals("") && !txtcredito.Text.Equals("") && !txtdireccion.Text.Equals("") && !txtnombre.Text.Equals("") && !txttelefono.Text.Equals(""))
        {
            String response = ws.EditarDatosCliente(user, nombre, apellido, direccion, telefono, credito, cod);
            if (response.Equals("OK"))
            {
                string message = "Datos actualizados exitosamente!";
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
                string message = "ERROR.. No se puede actualizar los datos.";
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