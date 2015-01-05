<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageCMS.Master" AutoEventWireup="true" CodeBehind="News_overview.aspx.cs" Inherits="RudarelNews.News_overview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/AddNewArticle.aspx">Add new article</asp:LinkButton>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="sds_articles" ForeColor="#333333" GridLines="None" Height="326px" Width="724px">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="title" HeaderText="title" SortExpression="title" />
        <asp:BoundField DataField="text" HeaderText="text" SortExpression="text" />
        <asp:BoundField DataField="author_name" HeaderText="author_name" SortExpression="author_name" />
        <asp:BoundField DataField="date_published" HeaderText="date_published" SortExpression="date_published" />
        <asp:BoundField DataField="category" HeaderText="category" SortExpression="category" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
<asp:SqlDataSource ID="sds_articles" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" DeleteCommand="DELETE FROM [Article] WHERE [id] = @id" InsertCommand="INSERT INTO [Article] ([id], [title], [text], [author_name], [date_published], [category]) VALUES (@id, @title, @text, @author_name, @date_published, @category)" SelectCommand="SELECT * FROM [Article]" UpdateCommand="UPDATE [Article] SET [title] = @title, [text] = @text, [author_name] = @author_name, [date_published] = @date_published, [category] = @category WHERE [id] = @id">
    <DeleteParameters>
        <asp:Parameter Name="id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="id" Type="Int32" />
        <asp:Parameter Name="title" Type="String" />
        <asp:Parameter Name="text" Type="String" />
        <asp:Parameter Name="author_name" Type="String" />
        <asp:Parameter Name="date_published" Type="DateTime" />
        <asp:Parameter Name="category" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="title" Type="String" />
        <asp:Parameter Name="text" Type="String" />
        <asp:Parameter Name="author_name" Type="String" />
        <asp:Parameter Name="date_published" Type="DateTime" />
        <asp:Parameter Name="category" Type="String" />
        <asp:Parameter Name="id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
    <br />
    <asp:Button ID="btnDeleteArticlesFromBD" runat="server" Text="Erase DB" OnClick="btnDeleteArticlesFromBD_Click" />
    <asp:Label ID="lblEraseBD" runat="server" Text=""></asp:Label>
</asp:Content>
