<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wishes_WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">
                <tr>
                    <td>
                      Enter Number 1:  <asp:TextBox ID="Txtbox1" runat="server"></asp:TextBox>
                      Enter Number 2:  <asp:TextBox ID="Txtbox2" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn1" runat="server" Text="Add Numbers" OnClick="btn1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Lbl1" runat="server" Text="">                          
                        </asp:Label>                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn2" runat="server" Text="Display Message" OnClick="btn2_Click"  />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
