using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class CurrentVotes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int total = 0;

        DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        foreach (DataRow r in dv.Table.Rows)
        {
            total = total + (int)r["Vote"];
        }
        //Label1.Text = total.ToString();

        TableRow title = new TableRow();
        TableCell t1 = new TableCell();
        TableCell t2 = new TableCell();
        TableCell t3 = new TableCell();
        title.Cells.Add(t1);
        title.Cells.Add(t2);
        title.Cells.Add(t3);
        t1.BorderWidth = 1;
        t1.BorderColor = Color.Black;
        t1.Width = 100;
        t2.BorderWidth = 1;
        t2.BorderColor = Color.Black;
        t2.Width = 100;
        t3.BorderWidth = 1;
        t3.BorderColor = Color.Black;
        t3.Width = 100;
        t1.Text = "Candidate";
        t2.Text = "Votes";
        t3.Text = "Percentage";
        Table1.Rows.Add(title);

        foreach (DataRow dr in dv.Table.Rows)
        {
            TableRow r = new TableRow();
            TableCell c1 = new TableCell();
            TableCell c2 = new TableCell();
            TableCell c3 = new TableCell();
            r.Cells.Add(c1);
            r.Cells.Add(c2);
            r.Cells.Add(c3);
            c1.BorderWidth = 1;
            c1.BorderColor = Color.Black;
            c1.Width = 100;
            c2.BorderWidth = 1;
            c2.BorderColor = Color.Black;
            c2.Width = 100;
            c3.BorderWidth = 1;
            c3.BorderColor = Color.Black;
            c3.Width = 100;
            c1.Text = dr["Name"].ToString();
            c2.Text = dr["Vote"].ToString();
            c3.Text = ((double)(int)dr["Vote"] / total).ToString("P");
            Table1.Rows.Add(r);
        }
    }
}