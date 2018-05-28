using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Acceuil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DBConnection.loadAccountTypes();
        DBConnection.loadClientsAccounts();
        DBConnection.loadClientsList();
        DBConnection.loadTransactionType();
       
    }


    protected void goToDeposit(object sender, EventArgs e)
    {
        Response.Redirect("Deposit.aspx");
    }

    protected void goToTransfert(object sender, EventArgs e)
    {
        Response.Redirect("Transfert.aspx");
    }

    protected void goToWithdrawal(object sender, EventArgs e)
    {
        Response.Redirect("WhitDrawal.aspx");
    }

    protected void goToHistory(object sender, EventArgs e)
    {
        Response.Redirect("History.aspx");
    }

    protected void goToAddClient(object sender, EventArgs e)
    {
        Response.Redirect("AddClient.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}