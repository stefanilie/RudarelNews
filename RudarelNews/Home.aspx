<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RudarelNews.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label ID="lblOrderBy" runat="server" Text="Order by:"></asp:Label>
        <asp:Button ID="btnOrderDate" runat="server" Text="Date" OnClick="btnOrderDate_Click" />
        <asp:Button ID="btnOrderTitle" runat="server" Text="Title" OnClick="btnOrderTitle_Click" />
    <br />
    <asp:Label ID="lblOutputHome" runat="server" Text="Label"></asp:Label>
</asp:Content>
