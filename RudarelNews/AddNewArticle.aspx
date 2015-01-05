<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCMS.Master" AutoEventWireup="true" CodeBehind="AddNewArticle.aspx.cs" Inherits="RudarelNews.AddNewArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3> Add new article</h3>
    <table cellspacing="15" class="articleTable" style="width: 511px">
        <tr>
            <td style="width: 79px">

                &nbsp;Title&nbsp;</td>
            <td>

                <asp:TextBox ID="tbArticleTitle" runat="server" OnTextChanged="TextBox1_TextChanged" Width="662px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 79px">

                Text</td>
            <td>

                <asp:TextBox ID="tbArticleText" runat="server" Height="247px" TextMode="MultiLine" Width="665px"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 79px">

                Category</td>
            <td>

                <asp:DropDownList ID="ddCategory" runat="server" Height="16px" Width="206px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Sport</asp:ListItem>
                    <asp:ListItem>Tech</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
    </table>
    <asp:Label ID="labelResults" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnPublishArticle" runat="server" Text="Publish" />
</asp:Content>
