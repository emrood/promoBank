using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class History : System.Web.UI.Page
{
    protected int noCompte;
    protected StringWriter stringWriter;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Action du boutton qui va retourner la liste de transaction d'un client
    protected void requestHistory(object sender, EventArgs e)
    {
        LabelInfo.CssClass = "alert alert-danger";
        if (TB_no_compte.Text != String.Empty)
        {
            try
            {
                noCompte = int.Parse(TB_no_compte.Text);
                if(noCompte > 0)
                {
                    if (DBConnection.loadAccountHistory(noCompte))
                    {
                        LabelInfo.CssClass = "alert alert-success";
                        LabelInfo.Text = "Succès";

                        TableRow t = new TableRow();
                        TableCell n = new TableCell();
                        TableCell p = new TableCell();
                        TableCell ni = new TableCell();
                        TableCell l = new TableCell();
                        TableCell m = new TableCell();
                        TableCell d = new TableCell();
                        t.CssClass = "resultRow";
                        n.CssClass = "mainCell";
                        p.CssClass = "mainCell";
                        ni.CssClass = "mainCell";
                        l.CssClass = "mainCell";
                        m.CssClass = "mainCell";
                        d.CssClass = "mainCell";
                        n.Text = "Nom";
                        p.Text = "Prenom";
                        ni.Text = "NIF";
                        l.Text = "type";
                        m.Text = "Montant";
                        d.Text = "Date";
                        t.Cells.Add(n);
                        t.Cells.Add(p);
                        t.Cells.Add(ni);
                        t.Cells.Add(l);
                        t.Cells.Add(m);
                        t.Cells.Add(d);
                        resultTable.Rows.Add(t);
                        resultTable.DataBind();

                        foreach (ClientHistory ch in DBConnection.histories)
                        {
                            TableRow tr = new TableRow();
                            TableCell nom = new TableCell();
                            TableCell prenom = new TableCell();
                            TableCell nif = new TableCell();
                            TableCell libele = new TableCell();
                            TableCell montant = new TableCell();
                            TableCell date = new TableCell();
                            nom.CssClass = "resultCell";
                            prenom.CssClass = "resultCell";
                            nif.CssClass = "resultCell";
                            libele.CssClass = "resultCell";
                            montant.CssClass = "resultCell";
                            date.CssClass = "resultCell";
                            nom.Text = ch.Nom;
                            prenom.Text = ch.Prenom;
                            nif.Text = ch.Nif.ToString();
                            libele.Text = ch.Libele;
                            montant.Text = ch.Montant.ToString();
                            date.Text = ch.Date.ToString();
                            tr.Cells.Add(nom);
                            tr.Cells.Add(prenom);
                            tr.Cells.Add(nif);
                            tr.Cells.Add(libele);
                            tr.Cells.Add(montant);
                            tr.Cells.Add(date);
                            resultTable.Rows.Add(tr);
                            resultTable.DataBind();
                        }

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

    public void OutputDataRows()
    {
        
    }
}