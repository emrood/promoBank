<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transfert.aspx.cs" Inherits="Transfert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
     <title>PromoBank</title>
    <link rel="stylesheet" href="style/transfert.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2 id="titre" class="display-4">Réaliser un transfert</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
    <div class="myContainer">
        <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label1" runat="server" CssClass="input-group-text"  Text="No du compte a crediter: "></asp:Label> </div>
            <asp:TextBox ID="TB_no_compte1" CssClass="form-control" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox></div><br />

                    <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label3" runat="server" CssClass="input-group-text"  Text="No du compte a débiter: "></asp:Label> </div>
            <asp:TextBox ID="TB_no_compte2" CssClass="form-control" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox></div><br />

                    <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label2" runat="server"  CssClass="input-group-text" Text="Montant"></asp:Label> </div>
            <asp:TextBox ID="TB_montant"  CssClass="form-control" TextMode="Number" ToolTip="2000"  runat="server"></asp:TextBox></div><br />

         <div><asp:Button ID="Valider" CssClass="btn btn-primary" OnClick="makeTransfert" runat="server"  Text="Valider" /></div>
        <br />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
