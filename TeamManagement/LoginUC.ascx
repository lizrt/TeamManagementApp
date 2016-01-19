<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUC.ascx.cs" Inherits="TeamManagement.LoginUC" %>
<asp:Panel ID="Panel1" runat="server" Height="163px">
    <table>
        <tr>
            <td>
                <asp:Label ID="lblUsrname" runat="server" Text="UserName"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:TextBox ID="txtusrname" runat="server"></asp:TextBox></td>

        </tr>
        <tr>
            <td>
                <asp:Label ID="lblpw" runat="server" Text="Password"></asp:Label></td>
            <td>:</td>
            <td>
                <asp:TextBox ID="txtpw" runat="server"></asp:TextBox></td>

        </tr>
        <tr><td colspan="3">
            <asp:CheckBox ID="chkRemember" Text="Remember Me" runat="server" />
            </td>
        </tr>
        <tr>
            <asp:Label ID="lblmsg" runat="server" Visible="false" Text=""></asp:Label></tr>
         <tr><td>
             <asp:Button ID="btnLogin" runat="server" Text="Login" Width="100px" onclick="btnLogin_Click"/>
            </td>
        </tr>
    </table>
</asp:Panel>

