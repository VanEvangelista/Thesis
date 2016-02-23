<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserControl.aspx.cs" Inherits="UserControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <br />
        Welcome! <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
&nbsp;<table style="height: 470px">
         <tr>
            <td>
                First Name:
            </td>
            <td>
                <asp:TextBox ID="f_name" runat="server" ></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                Last Name:
            </td>
            <td>
                <asp:TextBox ID="l_name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                ID Number:</td>
            <td>
                <asp:TextBox ID="id_num" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                Password:</td>
            <td>
                <asp:TextBox ID="user_pass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                Contact:</td>
            <td>
                <asp:TextBox ID="contact_num" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                DLSU Email:
            </td>
            <td>
                <asp:TextBox ID="dlsu_email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                S.Y.:
            </td>
            <td>
                <asp:TextBox ID="school_yr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                Term:
            </td>
            <td>
                <asp:DropDownList ID="term_drop" runat="server">
                    <asp:ListItem>Term 1</asp:ListItem>
                    <asp:ListItem>Term 2</asp:ListItem>
                    <asp:ListItem>Term 3</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <td>

        </td>
         <tr>
            <td>
                Preffered Room: </td>
            <td>
                <asp:DropDownList ID="room_drop" runat="server">
                    <asp:ListItem>108</asp:ListItem>
                    <asp:ListItem>109</asp:ListItem>
                    <asp:ListItem>110</asp:ListItem>
                    <asp:ListItem>111</asp:ListItem>
                    <asp:ListItem>112</asp:ListItem>
                    <asp:ListItem>113</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    <tr>
    <td colspan="2" align="center">
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
    </td>
        </tr>
        <tr>
            <td>
            <a href="LogOut.aspx"><asp:Label ID="Label1" runat="server" Text="LOG OUT"></asp:Label></a>
            </td>
        </tr>
    </tr>
    
    
    </table>
    </div>
    </form>
</body>
</html>
