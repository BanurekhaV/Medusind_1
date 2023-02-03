<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Day1EmptyTemplatePrj.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Our WebForm Project</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            &nbsp; &nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp;<asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
           &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnClick" runat="server"  Text="Click Me" BackColor="#CC6600" ForeColor="#0033CC" OnClick="BtnClick_Click" />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
