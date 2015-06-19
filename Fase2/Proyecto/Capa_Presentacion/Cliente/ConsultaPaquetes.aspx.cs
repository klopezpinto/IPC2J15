using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cliente_ConsultaPaquetes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label32.Text = Session["textboxValue"].ToString();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            int index = Convert.ToInt32(e.CommandArgument);
            int id = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Session["ValorKey"] = id.ToString();

            Response.Redirect("PaqueteIndividual.aspx");
        }
    }
}