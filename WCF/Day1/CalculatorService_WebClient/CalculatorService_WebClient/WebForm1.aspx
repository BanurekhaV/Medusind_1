<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorService_WebClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter First Number :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Enter Second Number :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <br />
            Enter Your Name :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Add Numbers" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Greet" OnClick="Button2_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
