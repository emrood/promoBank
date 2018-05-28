﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WhitDrawal.aspx.cs" Inherits="WhitDrawal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>PromoBank</title>
    <link rel="stylesheet" href="style/whitdrawal.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2 id="titre" class="display-4">Réaliser un retrait</h2>
    <div><a href="Acceuil.aspx">Page d'acceuil</a></div>
    <form id="form1" runat="server">
    <div>
        <div class="myContainer">
             <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label1" CssClass="input-group-text" runat="server" Text="No du compte : "></asp:Label> 
                    </div>
            <asp:TextBox ID="TB_no_compte" CssClass="form-control" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox></div><br />

             <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label2" CssClass="input-group-text" runat="server" Text="Montant"></asp:Label> </div>
            <asp:TextBox ID="TB_montant" CssClass="form-control" TextMode="Number" ToolTip="2000"  runat="server"></asp:TextBox></div><br />

          <div><asp:Button ID="Valider" CssClass="btn btn-primary" OnClick="makeWhitDrawal" runat="server"  Text="Valider" /></div>
            <br />

            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
            </div>

        </div>
    
    </div>
    </form>
</body>
</html>
