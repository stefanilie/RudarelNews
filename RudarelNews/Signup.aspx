<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="SIgnup.aspx.cs" Inherits="RudarelNews.SIgnup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 195px; text-align: right; height: 26px">Username:</td>
            <td style="width: 136px; height: 26px">
                <asp:TextBox ID="tbUsername" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="height: 26px; width: 236px">
                <asp:RequiredFieldValidator ID="tb" runat="server" ControlToValidate="tbUsername" ErrorMessage="Username required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right">Email:</td>
            <td style="width: 136px">
                <asp:TextBox ID="tbEmail" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 236px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email required." Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="Invalid email. email@host.com" Font-Bold="True" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right; height: 26px">Password:</td>
            <td style="width: 136px; height: 26px">
                <asp:TextBox ID="tbPass" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="height: 26px; width: 236px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbPass" ErrorMessage="Password required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right">Confirm password:</td>
            <td style="width: 136px">
                <asp:TextBox ID="tbCPass" runat="server" Width="150px"></asp:TextBox>
            </td>
            <td style="width: 236px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbCPass" ErrorMessage="Confirm password required." Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbCPass" ControlToValidate="tbPass" ErrorMessage="Password don't match." Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right">&nbsp;</td>
            <td style="width: 136px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </td>
            <td style="width: 236px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right">&nbsp;</td>
            <td style="width: 136px">&nbsp;</td>
            <td style="width: 236px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 195px; text-align: right">&nbsp;</td>
            <td style="width: 136px">&nbsp;</td>
            <td style="width: 236px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
