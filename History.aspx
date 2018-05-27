<%@ Page Language="C#" AutoEventWireup="true" CodeFile="History.aspx.cs" Inherits="History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="No du compte: "></asp:Label> 
            <asp:TextBox ID="TB_no_compte1" TextMode="Number" ToolTip="3" runat="server"></asp:TextBox><br />
         <asp:Button ID="Valider" OnClick="makeTransfert" runat="server"  Text="Recherche" />
            <div id="Info">
                <asp:Label ID="LabelInfo" runat="server" Text="Label" Visible="false"></asp:Label>
             </div>
    </div>
    </form>
</body>
</html>
