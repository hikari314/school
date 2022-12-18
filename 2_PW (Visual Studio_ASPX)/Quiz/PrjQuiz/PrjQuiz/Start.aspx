<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="PrjQuiz.Start" %>

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
                <asp:Label ID="Label1" runat="server" Text="Welcome!"></asp:Label>
            </h1></center>
            <br /><br />
            <!o GroupName é para poder escolher só um, pq se tirar, dá para selecionar todos>
            <asp:Label ID="Label2" runat="server" Text="We are going to have C# Desktop?"></asp:Label>
            <br /><br />
            <asp:RadioButton ID="RdoOpt1" GroupName="Opt" runat="server" Text="Maybe" />
            <br /><br />
            <asp:RadioButton ID="RdoOpt2" GroupName="Opt" runat="server" Text="Yes"/>
            <br /><br />
            <asp:RadioButton ID="RdoOpt3" GroupName="Opt" runat="server" Text="No"/>
            <br /><br />
            <asp:RadioButton ID="RdoOpt4" GroupName="Opt" runat="server" Text="Just God knows"/>
            <br /><br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
