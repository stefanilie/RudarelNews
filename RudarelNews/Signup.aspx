﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="RudarelNews.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%">
    <tr>
        <td style="text-align: right; width: 145px">Username:</td>
        <td>
            <asp:TextBox ID="tbUserName" runat="server" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUserName" ErrorMessage="Userame is required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px; height: 49px;">E-mail:</td>
        <td style="height: 49px">
            <asp:TextBox ID="tbEmail" runat="server" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbEmail" ErrorMessage="Required email." Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid email. example@host.com" Font-Bold="True" ForeColor="Red" ControlToValidate="tbEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td style="height: 49px"></td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px">Password:</td>
        <td>
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password required. 5 chars at least" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px; height: 49px">Confirm Password:</td>
        <td style="height: 49px">
            <asp:TextBox ID="tbCPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbPassword" ControlToValidate="tbCPass" ErrorMessage="Incorrect password" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbCPass" ErrorMessage="Confirm password required" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
        <td style="height: 49px"></td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align: right; width: 145px">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
