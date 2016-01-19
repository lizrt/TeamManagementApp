<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UserLogin.aspx.cs" Inherits="TeamManagement.UserLogin" %>

<%@ Register Src="~/LoginUC.ascx" TagPrefix="uc1" TagName="LoginUC" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
        <uc1:LoginUC runat="server" id="LoginUC" OnLoginClick="loginUC_click" /></section>
            </div>
        </div>
    </asp:Content>