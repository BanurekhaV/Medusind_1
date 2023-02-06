<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="CachingPrj.CacheForm" %>
<%@ OutputCache Duration="30" VaryByParam="None" Location="Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Select a Product from Here :
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="SmartWatch" Value="SmartWatch"></asp:ListItem>
                <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
                <asp:ListItem Text="Desktops" Value="Desktops"></asp:ListItem>
                <asp:ListItem Text="iPhones" Value="iPhone"></asp:ListItem>
                <asp:ListItem Text="LED TV" Value="LED TV"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
            <br />
        </div>
        <p>
            Server Time :
        
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </p>
&nbsp;

        Client Time :
        <script>
            document.write(Date());
        
            </script>
    </form>
</body>
</html>
