<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CRUD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <!--Alert for Error | Success Message-->
            <div visible="false" runat="server" id="DIV_SUCCESS" style="background-color: green">
                <asp:Label ID="LBL_SUCCESS" runat="server" style="color: white"></asp:Label>
            </div>
            <div visible="false" runat="server" id="DIV_ERROR" style="background-color: red">
                <asp:Label ID="LBL_ERROR" runat="server" style="color: white"></asp:Label>
            </div>
            <!--Finish-->

            <table>
                <tr>
                    <th>Username</th>
                    <td>
                        <asp:TextBox ID="TXT_UN" placeholder="Enter Username" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TXT_UN" ErrorMessage="Enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Password</th>
                    <td><asp:TextBox ID="TXT_PASS" placeholder="Enter Password" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TXT_PASS" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>&nbsp;</th>
                    <td>
                        <asp:Button ID="BTN_LOGIN" runat="server" Text="Login" OnClick="BTN_LOGIN_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="BTN_CANCLE" runat="server" Text="Cancle" OnClick="BTN_CANCLE_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
