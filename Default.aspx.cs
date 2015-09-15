using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem != null)
        {
            SqlDataSource1.Update();
            Response.Redirect("Votes.aspx");
            return;
        }
        else
        {
            Label1.Text = "Please select an candidate!";
            return;
        }

    }
}