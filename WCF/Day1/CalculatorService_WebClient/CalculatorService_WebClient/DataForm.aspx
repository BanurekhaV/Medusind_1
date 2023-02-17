<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm.aspx.cs" Inherits="CalculatorService_WebClient.DataForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Empid: <asp:TextBox ID="Textid" runat="server"></asp:TextBox><br /><br />
            EmpName :<asp:TextBox ID="Textname" runat="server" ></asp:TextBox> <br /><br />

           Gender <asp:TextBox ID="Textgender" runat="server"></asp:TextBox> <br /><br />
           DOB <asp:TextBox ID="Textdob" runat="server"></asp:TextBox><br /><br />

            <br />
            <br />
            <asp:Button ID="BtnGetEmployee" runat="server" Text="Get Employee Details" OnClick="BtnGetEmployee_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSaveEmployee" runat="server" Text="Save Employee" />

        </div>
    </form>
</body>
</html>
