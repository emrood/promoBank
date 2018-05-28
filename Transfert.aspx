<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transfert.aspx.cs" Inherits="Transfert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>PromoBank</title>
    <link rel="stylesheet" href="style/transfert.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2>Réaliser un transfert</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
    <div>
            <asp:Label ID="Label1" runat="server" Text="No du compte a crediter: "></asp:Label> 
            <asp:TextBox ID="TB_no_compte1" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label3" runat="server" Text="No du compte a débiter: "></asp:Label> 
            <asp:TextBox ID="TB_no_compte2" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox><br />

            <asp:Label ID="Label2" runat="server" Text="Montant"></asp:Label> 
            <asp:TextBox ID="TB_montant" TextMode="Number" ToolTip="2000"  runat="server"></asp:TextBox><br />

            <asp:Button ID="Valider" OnClick="makeTransfert" runat="server"  Text="Valider" />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
