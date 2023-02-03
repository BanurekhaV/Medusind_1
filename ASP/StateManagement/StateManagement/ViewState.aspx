<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManagement.ViewState" %>

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
            
            
            <asp:Button ID="btnStore" runat="server" Text="Store" OnClick="btnStore_Click"  />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click"  />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
