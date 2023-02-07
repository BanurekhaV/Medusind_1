<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CustomControlsPrj.WebForm1" %>

<%@ Register Assembly="UserControlsPrj" Namespace="UserControlsPrj" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:WebCustomControl1 ID="WebCustomControl1" runat="server" imgbuttonUrl="Images/Calendar.png" />
            <br />
        </div>
    </form>
</body>
</html>
