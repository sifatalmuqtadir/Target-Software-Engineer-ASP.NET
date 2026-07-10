<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWorld2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 190px;
        }
        .auto-style2 {
            width: 210px;
        }
    </style>
</head>
<body>
    <h1>My New Web Page</h1>
    <form id="form1" runat="server">
        <div>
            
            <%--<br />
            <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="displayButton" runat="server" OnClick="displayButton_Click1" Text="Show" />
            <input name="nameTextBox" type="text" id="nameTextBox" style="width:222px;">
            <asp:Label ID="messageLabel" runat="server" Text="Label"></asp:Label>--%>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="nameLabel" runat="server" Text="Name" Style="display:block;text-align:right;"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="nameTextBox" runat="server" Width="221px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                        <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="outputLabel" runat="server" Text="Output" Style="display:block;text-align:right;"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="outputTextBox" runat="server" Width="221px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>


        </div>
    </form>
</body>
</html>
