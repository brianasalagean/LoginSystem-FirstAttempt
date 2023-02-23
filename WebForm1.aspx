<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPLoginSystem.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="site.css" />
</head>
<body>
    <h1>Welcome</h1>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:Label ID="usernamelbl" runat="server" Text="User Name"></asp:Label>
            </div>
            <div>
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            </div>
            <asp:Label ID="passwdlbl" runat="server" Text="Password"></asp:Label>
            <div>
            <asp:TextBox ID="passwd" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="hiddenlbl">
            <asp:Label ID="confirmationlbl" runat="server" Text="Confirmation" Visible="false"></asp:Label>
            </div>
            <div>
            <asp:Button ID="loginButton" runat="server" OnClick="loginClick" Text="Login" />
            <asp:Button ID="resetButton" runat="server" OnClick="resetClick" Text="Reset" />
            </div>
        </div>
    </form>
</body>
</html>
