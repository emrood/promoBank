using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class History : System.Web.UI.Page
{
    protected int noCompte;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void requestHistory(object sender, EventArgs e)
    {
        if(TB_no_compte.Text != String.Empty)
        {
            try
            {
                noCompte = int.Parse(TB_no_compte.Text);
                if(noCompte > 0)
                {
                    if (DBConnection.loadAccountHistory(noCompte))
                    {
                        LabelInfo.Text = "Succès";
                    }
                    else
                    {
                        LabelInfo.Text = "Erreur de connection";
                    }
                }
                else
                {
                    LabelInfo.Text = "No de compte incorrect";
                }
                
            }catch(Exception ex)
            {
                string ms = ex.Message;
                LabelInfo.Text = "Erreur dans la convertion";
            }

        }else
        {
            LabelInfo.Text = "Champs vide";
        }

        LabelInfo.Visible = true;
    }
}