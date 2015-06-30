using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_Pedidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label32.Text = Session["textboxValue"].ToString();
    }
    protected void Cotizar_Click(object sender, EventArgs e)
    {
        if (!txtpeso.Text.Equals("") && !txtprecio.Text.Equals("") && !txtshipping.Text.Equals(""))
        {
            string comision = ""; string librapeso = "";
            string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
            SqlConnection con = new SqlConnection(DtsConection);

            int cod = Int32.Parse(Tipo0.Text);

            SqlCommand CMD = new SqlCommand("SELECT * FROM Sucursal WHERE cod_sucursal = " + cod + ";", con);
            con.Open();
            SqlDataReader leer = CMD.ExecuteReader();
            if (leer.Read() == true)
            {
                librapeso = leer["costolibras"].ToString();
                comision = leer["comision"].ToString();
            }
            con.Close();

            double precious = Int32.Parse(txtprecio.Text);
            double precious8 = precious * 7.9;
            lblmerc.Text = precious8.ToString();
            double shipping = Int32.Parse(txtshipping.Text);
            double shipping8 = shipping * 7.9;
            lblshipping.Text = shipping8.ToString();
            double pesolibras = Int32.Parse(txtpeso.Text);
            double porcentaje = Int32.Parse(Tipo.Text);

            double servicio = ((precious * 7.9) + (shipping * 7.9) + Int32.Parse(comision) + (pesolibras * Int32.Parse(librapeso)));
            double impuesto = servicio * (porcentaje * 0.01);
            double total = servicio + impuesto;
            lblservicio.Text = servicio.ToString();
            lblimpuestos.Text = impuesto.ToString();
            lbltotal.Text = total.ToString();
        }
        else
        {
            string message = "Ingrese todos los campos solicitados";
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