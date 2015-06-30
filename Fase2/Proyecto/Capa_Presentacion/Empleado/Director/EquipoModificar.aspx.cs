using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado_Director_Equipo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.BindGrid();
        }
    }

    private void BindGrid()
    {
        string DtsConection = "Server=HPKELP\\SQLEXPRESSK; Initial Catalog=QuetzalExpress;Trusted_Connection=YES;";
        SqlConnection con = new SqlConnection(DtsConection);
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                String dep = Session["departamento"].ToString();
                String suc = Session["sucursal"].ToString();
                cmd.CommandText = "select cod_empleado, puesto, sueldo, Usuario_cod_usuario, Sucursal_cod_Sucursal from Empleado Where Departamento_cod_departamento = " + dep + " AND Sucursal_cod_sucursal = " + suc + ";";
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
            int codusuario = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Session["ValorKey"] = codusuario.ToString();

            Response.Redirect("ModificarContratacion.aspx");
        }
    }
}