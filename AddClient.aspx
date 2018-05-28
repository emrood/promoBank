<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddClient.aspx.cs" Inherits="AddClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PromoBank</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link rel="stylesheet" href="style/addClient.css"/>
    <link rel="stylesheet" href="style/bootstrap.css"/>
    <link rel="stylesheet" href="style/bootstrap.min.css"/>
    <link rel="stylesheet" href="style/bootstrap-grid.css"/>
</head>
<body>
    <h2 id="titre" class="display-4" >Nouveau client</h2>
    <div><a href="Acceuil.aspx">Retour a la page d'acceuil</a></div>
    <form id="form1"  runat="server">
        <div class="form_container"  >

            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <asp:Label ID="Label1" CssClass="input-group-text" runat="server" Text="Nom: "></asp:Label>
                 </div>
            <asp:TextBox ID="TBlname" CssClass="form-control" ToolTip="Julien" runat="server"></asp:TextBox>
             </div>


            <br />

            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <asp:Label ID="Label2" CssClass="input-group-text" runat="server" Text="Prenom: "></asp:Label>
                </div>
            <asp:TextBox ID="TBfname"  CssClass="form-control" ToolTip="jean" runat="server"></asp:TextBox>
            </div>


            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
                    <asp:Label ID="Label3" CssClass="input-group-text" runat="server" Text="Sexe: "></asp:Label>
                </div>
            <asp:DropDownList ID="listSexe" CssClass="form-control" runat="server" >
                <asp:ListItem Enabled="true" Text="Selectionner un genre" Value="-1"></asp:ListItem>
                <asp:ListItem Text="M" Value="M"></asp:ListItem>
                <asp:ListItem Text="F" Value="F"></asp:ListItem>
            </asp:DropDownList>
            </div>


            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label4"  CssClass="input-group-text" runat="server" Text="NIF: "></asp:Label>
                    </div>
            <asp:TextBox ID="TBnif" CssClass="form-control" ToolTip="0029617716" TextMode="Number" runat="server"></asp:TextBox>
            </div>


            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label5" CssClass="input-group-text" runat="server" Text="CIN: "></asp:Label>
                    </div>
            <asp:TextBox ID="TBcin" CssClass="form-control" ToolTip="3652558963" TextMode="Number" runat="server"></asp:TextBox>
            </div>


            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label6" CssClass="input-group-text" runat="server" Text="Adresse: "></asp:Label>
                    </div>
            <asp:TextBox ID="TBadresse" CssClass="form-control" ToolTip="2, Rue Dalencourt, Canape-Vert" runat="server"></asp:TextBox>
            </div>


            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label7" CssClass="input-group-text" runat="server" Text="Telephone: "></asp:Label>
                    </div>
            <asp:TextBox ID="TBtelephone"  CssClass="form-control" ToolTip="36888860" TextMode="Number" runat="server"></asp:TextBox>
             </div>


            <br />
             
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label8" CssClass="input-group-text" runat="server" Text="Type de compte: "></asp:Label>
                    </div>
            <asp:DropDownList ID="T_account" CssClass="form-control" runat="server" OnSelectedIndexChanged="T_account_SelectedIndexChanged">
                <asp:ListItem Enabled="true" Text="Selectionner un type de compte" Value="-1"></asp:ListItem>
                <asp:ListItem Text="courant" Value="1"></asp:ListItem>
                <asp:ListItem Text="epargne" Value="2"></asp:ListItem>
            </asp:DropDownList>
             </div>



            <br />
            
            <div class="input-group mb-3">
                <div class="input-group-prepend">
            <asp:Label ID="Label9" CssClass="input-group-text" runat="server" Text="Solde (En gdes): "></asp:Label>
                    </div>
            <asp:TextBox ID="TBsolde" ToolTip="500" CssClass="form-control" runat="server" Width="796px"></asp:TextBox>
             </div>


            <br />
             <div id="btn_contain">
            <asp:Button ID="BTSave" CssClass="btn btn-primary" runat="server" Text="Sauvegarder" OnClick="registerClient" />
                 <br /><br />
            <div><asp:Label ID="info" visible="false" runat="server"  Text="Label"></asp:Label></div>
           </div>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
