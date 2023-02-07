<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyCalendarControl.ascx.cs" Inherits="UserControlsPrj.MyCalendarControl" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="60px" ImageUrl="Images/Calendar.png" OnClick="ImageButton1_Click" Width="31px" />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>