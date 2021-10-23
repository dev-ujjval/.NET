<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CRUD.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Login.aspx" runat="server">Login</asp:HyperLink>
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
                    <th>Name</th>
                    <td>
                        <asp:TextBox ID="TXT_NAME" placeholder="Enter Name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TXT_NAME" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Number</th>
                    <td><asp:TextBox ID="TXT_NUMBER" placeholder="Enter Number" TextMode="Number" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TXT_NUMBER" ErrorMessage="Enter Valid 10  digit number" ValidationExpression="[0-9]{10}" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <th>Address</th>
                    <td><asp:TextBox ID="TXT_ADDRESS" placeholder="Enter Address" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <th>Gender</th>
                    <td>
                        <asp:RadioButton ID="RBTN_MALE" runat="server" GroupName="gen" Text="Male"/>
                        <asp:RadioButton ID="RBTN_FEMALE" runat="server" GroupName="gen" Text="Female"/>
                    </td>
                </tr>
                <tr>
                    <th>Hobbies</th>
                    <td>
                        <asp:CheckBox ID="CB1" Text="basketball" runat="server" />
                        <asp:CheckBox ID="CB2" Text="WWE" runat="server" />
                        <asp:CheckBox ID="CB3" Text="volleyball" runat="server" />
                    </td>
                </tr>
                <tr>
                    <th>Username</th>
                    <td><asp:TextBox ID="TXT_UN" placeholder="Enter Email" TextMode="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TXT_UN" ErrorMessage="Enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TXT_UN" ErrorMessage="Enter Correct Username" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <th>Password</th>
                    <td><asp:TextBox ID="TXT_PASS" placeholder="Enter Password" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TXT_PASS" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <th>Confirm Password</th>
                    <td><asp:TextBox ID="TXT_CPASS" placeholder="Enter Confirm Number" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TXT_CPASS" ErrorMessage="Enter Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TXT_PASS" ControlToValidate="TXT_CPASS" ErrorMessage="Password Mismatch" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <th>&nbsp;</th>
                    <td>
                        <asp:Button ID="BTN_REG" runat="server" Text="Register" OnClick="BTN_REG_Click" /> |
                        <asp:Button ID="BTN_CANCLE" runat="server" Text="Cancle" OnClick="BTN_CANCLE_Click" /> 
                        
                    </td>
                </tr>
            </table>

        </div>
    </form>

</body>
</html>
