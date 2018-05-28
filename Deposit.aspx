<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Deposit.aspx.cs" Inherits="Deposit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>PromoBank</title>
    <link rel="stylesheet" href="style/deposit.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2 id="titre" class="display-4" >Realiser un depot</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
        <div class="myContainer">
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label1" CssClass="input-group-text" runat="server" Text="No du compte : "></asp:Label> 
                    </div>
            <asp:TextBox ID="TB_no_compte"  CssClass="form-control" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox>
                </div>
            <br />
                    <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label2" CssClass="input-group-text" runat="server" Text="Montant"></asp:Label> 
                    </div>
            <asp:TextBox ID="TB_montant"  CssClass="form-control" TextMode="Number" ToolTip="2000"  runat="server"></asp:TextBox>
                        </div>
                
                    <br />
                    <br />
            <div><asp:Button ID="Valider" runat="server" CssClass="btn btn-primary" OnClick="makeDeposit" Text="Valider" /></div>
                   <br />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
            </div>


        </div>
    </form>
</body>
</html>
