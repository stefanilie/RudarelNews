<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Errorpage.aspx.cs" Inherits="RudarelNews.Errorpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 330px;
            width: 769px;
        }
        #s {
            height: 477px;
            width: 790px;
        }
        #taError {
            height: 296px;
            width: 756px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="lblDate" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
