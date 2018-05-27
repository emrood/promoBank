using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddClient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }


    protected void registerClient(object sender, EventArgs e)
    {
        if ((T_account.SelectedIndex != 0) && 
            (listSexe.SelectedIndex != 0) && 
            (TBfname.Text != String.Empty) && 
            (TBnif.Text != String.Empty) && 
            (TBlname.Text != String.Empty) && 
            (TBcin.Text != String.Empty) && 
            (TBadresse.Text != String.Empty) && 
            (TBtelephone.Text != String.Empty))
        {
            if (DBConnection.registerClient(TBfname.Text, TBlname.Text, listSexe.SelectedValue, int.Parse(TBnif.Text), int.Parse(TBcin.Text), TBadresse.Text, TBtelephone.Text))
            {
                DateTime i = DateTime.Now;
                if(DBConnection.registerAccount(int.Parse(TBnif.Text), T_account.SelectedIndex, float.Parse(TBsolde.Text), i))
                {
                    info.Text = "Enregistre avec succes";
                    TBfname.Text = "";
                    TBnif.Text = "";
                    TBlname.Text = "";
                    TBcin.Text = "";
                    TBadresse.Text = "";
                    TBtelephone.Text = "";
                    T_account.SelectedIndex = 0;
                    listSexe.SelectedIndex = 0;
                }
                else
                {
                    info.Text = "Register account failed";
                }
            }
            else
            {
                info.Text = "Register client failed";
                info.Visible = false;
            }
        }
        else
        {
            info.Text = "Verifiez vos saisies";
        }

        info.Visible = true;
    }


    protected void BTSave_Click(object sender, EventArgs e)
    {

    }

    protected void T_account_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i = T_account.SelectedIndex;

    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            