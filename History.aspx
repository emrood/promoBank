<%@ Page Language="C#" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="History" %>

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
    <h2 id="titre" class="display-4" >Historique client</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
        <div class="myContainer" >
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label1" runat="server" CssClass="input-group-text"  Text="No du compte: "></asp:Label> </div>
            <asp:TextBox ID="TB_no_compte" CssClass="form-control" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox></div><br />

            <asp:Button ID="Valider" CssClass="btn btn-primary" OnClick="requestHistory" runat="server"  Text="Recherche" /><br />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
             </div>

            <br />
            <br />
            <asp:Label ID="Label_result" runat="server" Text="Label" Visible="false"></asp:Label>
            <div id="result" class="historyResult">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="false"></asp:Label>
                <!--Bloc to show result -->
             <% OutputDataRows(); %> 
            </div>
            <br />
        </div>
        
    </form>
</body>
</html>
