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
                        stringWriter = new StringWriter();
                        using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter))
                        {

                            writer.AddAttribute(HtmlTextWriterAttribute.Class, "historyResult");
                            writer.RenderBeginTag(HtmlTextWriterTag.Div); // Begin #1

                            writer.AddAttribute(HtmlTextWriterAttribute.Class, "table-responsive");
                            writer.RenderBeginTag(HtmlTextWriterTag.Table);
                            foreach (string s in DBConnection.historyResult)
                            {
                                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                                writer.AddAttribute(HtmlTextWriterAttribute.Class, "bg-primary");
                                writer.RenderBeginTag(HtmlTextWriterTag.Td);
                                writer.Write(s);
                                writer.RenderEndTag();
                                writer.RenderEndTag();
                            }
                            writer.RenderEndTag();
                           
                            writer.RenderEndTag(); // End #1

                        }

                        stringWriter.ToString();
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