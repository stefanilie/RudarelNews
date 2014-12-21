<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RudarelNews.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="width: 166px">&nbsp;</td>
        <td style="width: 163px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 166px; text-align: right">Username:</td>
        <td style="width: 163px">
            <asp:TextBox ID="tbLogUsr" runat="server" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbLogUsr" ErrorMessage="Username required." Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 166px; text-align: right">Password:</td>
        <td style="width: 163px">
            <asp:TextBox ID="tbLogPass" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLogPass" ErrorMessage="Password required." Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 166px">&nbsp;</td>
        <td style="width: 163px">
            <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" Text="Log in" Width="155px" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
