using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WhitDrawal : System.Web.UI.Page
{

    protected int compte = 0;
    protected float montant = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void makeWhitDrawal(object sender, EventArgs e)
    {

        //LabelInfo.CssClass = "";
        if ((TB_montant.Text != String.Empty) && (TB_no_compte.Text != String.Empty))
        {
            try
            {
                compte = int.Parse(TB_no_compte.Text);
                montant = float.Parse(TB_montant.Text);
            }
            catch (Exception ex)
            {
                String message = ex.Message;
            }

            if ((compte != 0) && (montant != 0))
            {
                if (DBConnection.whitDrawal(compte, montant))
                {
                    //LabelInfo.CssClass = "";
                    LabelInfo.Text = "Retrait effectué avec succès";
                }
                else
                {
                    LabelInfo.Text = "Erreur de connection";
                }
            }
            else
            {
                LabelInfo.Text = "Verifiez vos saisie";
            }
        }
        else
        {
            LabelInfo.Text = "Champs vide";
        }

        LabelInfo.Visible = true;
    }
}