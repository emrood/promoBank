using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transfert : System.Web.UI.Page
{

    protected int compte1 = 0;
    protected int compte2 = 0;
    protected float montant = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // Methode permettant de faire un transfert d'un compte a un autre
    protected void makeTransfert(object sender, EventArgs e)
    {

        LabelInfo.CssClass = "alert alert-danger";
        if ((TB_montant.Text != String.Empty) && (TB_no_compte1.Text != String.Empty) && (TB_no_compte2.Text != String.Empty))
        {
            try
            {
                compte1 = int.Parse(TB_no_compte1.Text);
                compte2 = int.Parse(TB_no_compte2.Text);
                montant = float.Parse(TB_montant.Text);
            }
            catch (Exception ex)
            {
                String message = ex.Message;
            }

            if ((compte1 != 0) && (montant != 0) && (compte2 != 0))
            {
                if (DBConnection.whitDrawal(compte1, montant) && DBConnection.deposit(compte2, montant))
                {
                    LabelInfo.CssClass = "alert alert-success";
                    LabelInfo.Text = "Transaction effectué avec succès";
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