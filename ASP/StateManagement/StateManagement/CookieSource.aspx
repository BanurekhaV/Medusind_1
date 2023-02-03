<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="StateManagement.CookieSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />            
            
            <asp:Button ID="btnRedirect" runat="server" Text="Redirect" OnClick="btnRedirect_Click"   />
        </div>
    </form>
</body>
</html>
