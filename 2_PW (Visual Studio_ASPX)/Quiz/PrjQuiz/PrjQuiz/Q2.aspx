<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q2.aspx.cs" Inherits="PrjQuiz.Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>
                <asp:Label ID="Label1" runat="server" Text="About Candies"></asp:Label>
            </h1></center>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="What Brazilian candy is made with a lot of eggs?"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="RdoOpt1" GroupName="Opt" runat="server" Text="Quindim" />
            <br /><br />
            <asp:RadioButton ID="RdoOpt2" GroupName="Opt" runat="server" Text="Pudin"/>
            <br /><br />
            <asp:RadioButton ID="RdoOpt3" GroupName="Opt" runat="server" Text="Brigadeiro"/>
            <br /><br />
            <asp:RadioButton ID="RdoOpt4" GroupName="Opt" runat="server" Text="Amendoim"/>
            <br /><br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
