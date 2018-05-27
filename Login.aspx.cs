using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void getAccountTypes(object sender, EventArgs e)
    {
        if (DBConnection.initConnection())
        {
            tbInfo.Text = "Connection succes";
            if (DBConnection.loadAccountTypes())
            {

                tbInfo.Text = "Data succes";
            }
            else
            {
                tbInfo.Text = "error getting data";
            }

        }
        else
        {
            tbInfo.Text = "Connection fail";

        }
    }
}