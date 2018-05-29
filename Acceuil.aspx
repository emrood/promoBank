<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Acceuil.aspx.cs" Inherits="Acceuil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>Acceuil</title>
    <link rel="stylesheet" href="style/transfert.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <header>
        <!--<h1 id="main_title" class="display-2">PromoBank Start Page</h1> -->
        <div class="imgContainer"><img alt="logo" ID="logo" class="myLogo"  src="media/promobank.png" /></div>
    </header>
    <marquee direction="left" loop="1" scrolldelay="5ms" behavior="slide" truespeed>
    <form id="form1"  runat="server">
            <div id="myMenu">
                <asp:Button ID="btn_addClient" CssClass="btn btn-primary" OnClick="goToAddClient" runat="server" Text="Nouveau client" />
                <asp:Button ID="btn_deposit" CssClass="btn btn-primary" OnClick="goToDeposit" runat="server" Text="Depot" />
                <asp:Button ID="btn_withDrawal" CssClass="btn btn-primary" OnClick="goToWithdrawal" runat="server" Text="Retrait" />
                <asp:Button ID="btn_transfert" CssClass="btn btn-primary" OnClick="goToTransfert" runat="server" Text="Virement Bancaire" />
                <asp:Button ID="btn_history" CssClass="btn btn-primary" OnClick="goToHistory" runat="server" Text="Historique" />
            </div>
    </form>
        </marquee>
    <style>
        .myLogo{
            width: 200px;
            height: 200px;
            text-align: center;
        }

        .imgContainer{
            margin-top: 50px;
            width: 210px;
            margin: auto;
            
        }

    </style>
</body>
</html>
