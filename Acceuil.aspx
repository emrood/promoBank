<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Acceuil.aspx.cs" Inherits="Acceuil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acceuil</title>
    <link rel="stylesheet" href="style/acceuil.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h1>Bienvenue sur la bank des bank</h1>
    <form id="form1" runat="server">
        <div>
            <ul>
                <li><a href="AddClient.aspx">Nouveau client</a></li>
                <li><a href="Deposit.aspx">Depot</a></li>
                <li><a href="WhitDrawal.aspx">Retrait</a></li>
                <li><a href="Transfert.aspx">Virement Bancaire</a></li>
                <li><a href="#">Historique</a></li>
            </ul>
        </div>
    </form>
</body>
</html>
