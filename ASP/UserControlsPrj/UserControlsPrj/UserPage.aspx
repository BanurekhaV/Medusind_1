<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="UserControlsPrj.UserPage" %>

<!--<%@ Register Src="~/MyCalendarControl.ascx" TagPrefix="uc1" TagName="MyCalendarControl" %>-->


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Date Of Joining : <uc1:MyCalendarControl runat="server" id="MyCalendarControl" SelectedDate="10/10/2022" />
       
            <br />
       
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
