using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_PaqueteIndividual : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label32.Text = Session["textboxValue"].ToString();
    }

    protected void Label30_Init(object sender, EventArgs e)
    {
        String cod_paq = Session["ValorKey"].ToString();

        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        SqlCommand CMD = new SqlCommand("SELECT * FROM Paquete WHERE cod_paquete = " + cod_paq + ";", con);
        con.Open();
        SqlDataReader leer = CMD.ExecuteReader();
        if (leer.Read() == true)
        {
            txtcodpaq.Text = leer["cod_paquete"].ToString();
            txtlibras.Text = leer["libras"].ToString();
            txtprecio.Text = leer["precio"].ToString();
            txtestado.Text = leer["estado"].ToString();
            txtcategoria.Text = leer["Impuesto_categoria"].ToString();

            double precio = Int32.Parse(txtprecio.Text);
            double libras = Int32.Parse(txtlibras.Text);

            double servicio = ((precio * 7.9) + 15 + (libras * 40));
            double impuesto = servicio * (15 * 0.01);
            double total = servicio + impuesto;

            txtmonto.Text = total.ToString();
        }
        con.Close();
    }
}