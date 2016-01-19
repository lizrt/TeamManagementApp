<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="TeamPage.aspx.cs" Inherits="TeamManagement.TeamPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
    <div><asp:GridView ID="GridView1" runat="server"></asp:GridView></div>
     <asp:Panel ID="HandlingErrorPanel" runat="server" Visible="true">
         <div><asp:LinkButton ID="ConfigLinkButton1" runat="server" OnClick="ConfigLinkButton1_Click">Config Error Handling</asp:LinkButton>
         </div>
         <div><asp:LinkButton ID="AppLinkButton1" runat="server" OnClick="AppLinkButton1_Click" >Application Error Handling</asp:LinkButton>
         </div>
          <div><asp:LinkButton ID="CodeLinkButton1" runat="server" OnClick="CodeLinkButton1_Click"  >Code Error Handling</asp:LinkButton>
         </div>
         </asp:Panel>
</asp:Content>

