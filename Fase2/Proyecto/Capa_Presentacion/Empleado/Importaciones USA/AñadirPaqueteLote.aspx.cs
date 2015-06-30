using Capa_Funciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Importaciones_AñadirPaqueteLote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);

        string consulta = "SELECT cod_paquete FROM Paquete WHERE estado = 'Registrado en USA'";
        SqlDataAdapter daAutores = new SqlDataAdapter(consulta, DtsConection);
        DataSet codpaq = new DataSet();
        daAutores.Fill(codpaq, "Codigo");
        DropDownList3.DataSource = codpaq.Tables["Codigo"].DefaultView;
        DropDownList3.DataTextField = "cod_paquete";
        DropDownList3.DataValueField = "cod_paquete";
        DropDownList3.DataBind();
    }

    protected void Contratar_Click(object sender, EventArgs e)
    {
        if (!txtfecha.Text.Equals(""))
        {
            WebService ws = new WebService();
            int codlote = Int32.Parse(DropDownList4.Text);
            String fecha = txtfecha.Text;
            int codpaq = Int32.Parse(DropDownList3.Text);
            int codsuc = Int32.Parse(DropDownList5.Text);

            String response = ws.AgregarPaqueteLote(codlote, fecha, codpaq, codsuc);
            if (response.Equals("OK"))
            {
                string message = "Paquete agregado a Lote exitosamente!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
                txtfecha.Text = "";
                Response.Redirect("AñadirPaqueteLote.aspx");
            }
            else
            {
                string message = "ERROR.. Esta paquete ya pertenece al Lote!";
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
}