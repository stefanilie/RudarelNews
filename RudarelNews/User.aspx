<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCMS.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="RudarelNews.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        <asp:Label ID="lblWelcome" runat="server" Text="Welcome, "></asp:Label>
                <br />
                <br />
        <asp:Button ID="btnLogOut" runat="server" Height="28px" Text="Log out" OnClick="Button1_Click" Width="55px" />
    </h3>
</asp:Content>
