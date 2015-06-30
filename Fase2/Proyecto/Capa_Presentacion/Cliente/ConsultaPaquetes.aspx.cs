using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_ConsultaPaquetes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindGrid();
        }

        Label32.Text = Session["textboxValue"].ToString();
    }

    private void BindGrid()
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                String dpi = Session["dpi"].ToString();
                cmd.CommandText = "select cod_paquete, estado, Impuesto_categoria from Paquete Where Cliente_dpi = " + dpi + ";";
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();
            }
        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int cod = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Session["ValorKey"] = cod.ToString();

            Response.Redirect("PaqueteIndividual.aspx");
        }
    }
}