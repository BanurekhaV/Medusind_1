<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieDestination.aspx.cs" Inherits="StateManagement.CookieDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl2" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnReceive" runat="server" Text="Receive" OnClick="btnReceive_Click" />
        </div>
    </form>
</body>
</html>
