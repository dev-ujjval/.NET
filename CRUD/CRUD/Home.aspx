<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CRUD.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello <asp:Label ID="LBL_NAME" runat="server" Text=""></asp:Label>
            <asp:Button ID="BTN_LOGOUT" runat="server" Text="Logout" OnClick="BTN_LOGOUT_Click" />
            <hr />Last Login at <asp:Label ID="LBL_DT" runat="server" Text=""></asp:Label>
            
         </div>
    </form>
</body>
</html>
