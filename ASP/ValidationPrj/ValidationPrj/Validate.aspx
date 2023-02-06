<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validate.aspx.cs" Inherits="ValidationPrj.Validate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:Red; font-size:20px ;">Registration Form</h1><br />
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot be Blank" 
                ForeColor="Red" ControlToValidate="Textname"></asp:RequiredFieldValidator>--%>
            <br />
            <br />
            Password :&nbsp;&nbsp;
            <asp:TextBox ID="Textpassword" runat="server" TextMode="Password"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="Textpassword" ErrorMessage="Password is Must" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            <br />
            <br />
            Confirm Password:&nbsp;&nbsp;
            <asp:TextBox ID="Textcpassword" runat="server" TextMode="Password"></asp:TextBox>
           <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="Textcpassword" Display="Dynamic" ErrorMessage="Enter Password to Confirm"
                ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="Textpassword" ControlToValidate="Textcpassword" Display="Dynamic" 
                ErrorMessage="Passwords Does not Match" ForeColor="Red"></asp:CompareValidator>--%>
            <br />
            <br />
            Age:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textage" runat="server" TextMode="Number"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="Textage" Display="Dynamic" ErrorMessage="Enter Age" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="Textage" ErrorMessage="Age to be between 18 and 35"
                ForeColor="Red" MaximumValue="35" MinimumValue="18" Type="Integer" Display="Dynamic"></asp:RangeValidator>--%>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
            <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textemail" Display="Dynamic" ErrorMessage="Please enter Email" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Textemail" Display="Dynamic" ErrorMessage="Enter Email in the Correct Format" ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
            <br />
            <br />
            <asp:Button ID="Btnregister" runat="server" Text="Register" OnClick="Btnregister_Click" />
            <br />
            <br />
            <br />
            <br />
            <%--<input id="Text1" type="text" />
            <input id="Btn" type="submit" value="Submit" runat="server" />--%>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
