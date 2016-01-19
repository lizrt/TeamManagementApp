<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Help.aspx.cs" Inherits="TeamManagement.Help" %>
<%@OutputCache Duration = "10" VaryByParam ="none" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Caching is very important concept for any web application. which is used to store the data temporarily either on a web server or on the client side (client system).In other words , Caching is a place where data is stored temporarily. This data can be stored for a specific time period on the server or client system.It is more useful when any user access the same set of data continuously</p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
