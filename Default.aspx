<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Visible="true" ReadOnly="True" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="CheckBox1" Checked="true" runat="server"/>
        <asp:CheckBox ID="CheckBox2" Checked="true" runat="server" />
    </div>
    </form>
</body>
</html>
