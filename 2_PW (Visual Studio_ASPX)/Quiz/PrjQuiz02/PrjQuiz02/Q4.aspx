<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q4.aspx.cs" Inherits="PrjQuiz02.Q4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <left><h3>
                ...
            </h3>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/notre.png" Height="500px" Width="700px" />
            <br />
            </left>
            <br />
            <asp:RadioButton ID="RdoOpt1" GroupName="Opt" runat="server" Text="The Hunchback of Notre Dame" />
            <br />
            <asp:RadioButton ID="RdoOpt2" GroupName="Opt" runat="server" Text="The Magic Cauldron" />
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
