<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddClient.aspx.cs" Inherits="AddClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PromoBank</title>
    <meta charset="UTF-8"/>
    <link rel="stylesheet" href="style/addClient.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h1>Nouveau client</h1>
    <div><a href="Acceuil.aspx">Retour a la page d'acceuil</a></div>
    <form id="form1"  runat="server">
        <div class="form_container"  >
            <asp:Label ID="Label1" CssClass="lab" runat="server" Text="Nom: "></asp:Label>
            <asp:TextBox ID="TBlname" ToolTip="Julien" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" CssClass="lab" runat="server" Text="Prenom: "></asp:Label>
            <asp:TextBox ID="TBfname" ToolTip="jean" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" CssClass="lab" runat="server" Text="Sexe: "></asp:Label>
            <asp:DropDownList ID="listSexe" runat="server" >
                <asp:ListItem Enabled="true" Text="Selectionner un genre" Value="-1"></asp:ListItem>
                <asp:ListItem Text="M" Value="M"></asp:ListItem>
                <asp:ListItem Text="F" Value="F"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4"  CssClass="lab" runat="server" Text="NIF: "></asp:Label>
            <asp:TextBox ID="TBnif" ToolTip="0029617716" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" CssClass="lab" runat="server" Text="CIN: "></asp:Label>
            <asp:TextBox ID="TBcin" ToolTip="3652558963" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" CssClass="lab" runat="server" Text="Adresse: "></asp:Label>
            <asp:TextBox ID="TBadresse" ToolTip="2, Rue Dalencourt, Canape-Vert" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" CssClass="lab" runat="server" Text="Telephone: "></asp:Label>
            <asp:TextBox ID="TBtelephone" ToolTip="36888860" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" CssClass="lab" runat="server" Text="Type de compte: "></asp:Label>
            <asp:DropDownList ID="T_account" runat="server" OnSelectedIndexChanged="T_account_SelectedIndexChanged">
                <asp:ListItem Enabled="true" Text="Selectionner un type de compte" Value="-1"></asp:ListItem>
                <asp:ListItem Text="courant" Value="1"></asp:ListItem>
                <asp:ListItem Text="epargne" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label9" CssClass="lab" runat="server" Text="Solde de depart: "></asp:Label>
            <asp:TextBox ID="TBsolde" ToolTip="500" runat="server"></asp:TextBox>
            <asp:Label ID="Label10" CssClass="lab" runat="server" Text="Gdes"></asp:Label>
            <br />
            <asp:Button ID="BTSave" runat="server" Text="Sauvegarder" OnClick="registerClient" /><br />
            <asp:Label ID="info" visible="false" runat="server"  Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
