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
            //
            // Se obtiene indice de la row seleccionada
            //
            int index = Convert.ToInt32(e.CommandArgument);

            //
            // Obtengo el id de la entidad que se esta editando
            // en este caso de la entidad Person
            //
            int id = Convert.ToInt32(GridView1.DataKeys[index].Value);
            Label34.Text = id.ToString();

        }

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //    GridViewRow row = GridView1.SelectedRow;

        //    //
        //    // Obtengo el id de la entidad que se esta editando
        //    // en este caso de la entidad Person
        //    //
        //    int id = Convert.ToInt32(GridView1.DataKeys[row.RowIndex].Value);
        //}
    }
}