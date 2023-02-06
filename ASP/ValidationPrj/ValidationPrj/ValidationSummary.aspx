<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationSummary.aspx.cs" Inherits="ValidationPrj.ValidationSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:Red; font-size:20px ;">Registration Form</h1>Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textname" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Cannot be Blank" 
                ForeColor="Red" ControlToValidate="Textname" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password :&nbsp;&nbsp;
            <asp:TextBox ID="Textpassword" runat="server" TextMode="Password"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="Textpassword" ErrorMessage="Password is Must" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password:&nbsp;&nbsp;
            <asp:TextBox ID="Textcpassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="Textcpassword" Display="Dynamic" ErrorMessage="Enter Password to Confirm"
                ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="Textpassword" ControlToValidate="Textcpassword" Display="Dynamic" 
                ErrorMessage="Passwords Does not Match" ForeColor="Red" ValidationGroup="Register">*</asp:CompareValidator>
            <br />
            <br />
            Age:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textage" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="Textage" Display="Dynamic" ErrorMessage="Enter Age" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="Textage" ErrorMessage="Age to be between 18 and 35"
                ForeColor="Red" MaximumValue="35" MinimumValue="18" Type="Integer" Display="Dynamic" ValidationGroup="Register">*</asp:RangeValidator>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Textemail" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textemail" Display="Dynamic" ErrorMessage="Please enter Email" ForeColor="Red" ValidationGroup="Register">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Textemail" Display="Dynamic" ErrorMessage="Enter Email in the Correct Format" ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Register">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Btnregister" runat="server" Text="Register" OnClick="Btnregister_Click" ValidationGroup="Register" />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="Register" />
            <br />
            <br />
        </div>
        <div>
            <hr />
            <h1 style="color:red; font-size:20px">Login Form</h1>
            Enter UserName : &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtuname" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtuname" ErrorMessage="Enter Login name" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>
            <br />
            Password :
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtpwd" ErrorMessage="Password must" ForeColor="Red" ValidationGroup="Login"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" ValidationGroup="Login" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" DisplayMode="List" ForeColor="Red" ValidationGroup="Login" />
        </div>
    </form>
</body>
</html>
