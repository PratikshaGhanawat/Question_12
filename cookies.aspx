<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookies.aspx.cs" Inherits="Cookies.cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cookie Counter</h2>
            <asp:Label ID="lblCookieCounter" runat="server" Text=""></asp:Label>

            <h2>Application State</h2>
            <asp:Label ID="lblApplicationState" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
