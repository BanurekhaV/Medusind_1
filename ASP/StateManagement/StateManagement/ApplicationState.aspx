<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="StateManagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnClick" runat="server" Text=" Click" OnClick="BtnClick_Click" />

            <br />
            <br />

            <br />
            <asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
