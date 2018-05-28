<%@ Page Language="C#" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PromoBank</title>
    <link rel="stylesheet" href="style/history.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2>Historique client</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="No du compte: "></asp:Label> 
            <asp:TextBox ID="TB_no_compte" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox><br />
            <asp:Button ID="Valider" OnClick="requestHistory" runat="server"  Text="Recherche" />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
             </div>
        </div>
        <div id="result">
            <!--Bloc to show result -->
            <asp:Label ID="Label_result" runat="server" Text="Label" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
