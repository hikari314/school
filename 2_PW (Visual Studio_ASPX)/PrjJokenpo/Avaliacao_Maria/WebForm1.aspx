<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Avaliacao_Maria.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Jokenpo" Font-Size="22px" Font-Bold="true"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="CPU Points:"></asp:Label>
            &nbsp;<asp:Label ID="LblPointsCPU" runat="server" Text="0"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label5" runat="server" Text="Player Points:"></asp:Label>
            &nbsp;<asp:Label ID="LblPlayerPoints" runat="server" Text="0"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Lbl" runat="server" Text="Result:" Font-Bold="true"></asp:Label>
            &nbsp;<asp:Label ID="LblResult" runat="server" Text="--"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="CPU Choice:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Player Choice:"></asp:Label>
            <br />
            <br />
            <asp:Image ID="ImgCPUChoice" runat="server" ImageUrl="~/images/white.png" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="ImgPlayerChoice" runat="server" ImageUrl="~/images/white.png" />
            <br />
            <br />
            <asp:ImageButton ID="ImgBtnPaper" runat="server" Height="80px" ImageUrl="~/images/paper.png" Width="80px" OnClick="ImgBtnPaper_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImgBtnRock" runat="server" Height="80px" ImageUrl="~/images/rock.png" Width="80px" OnClick="ImgBtnRock_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImgBtnScissors" runat="server" Height="80px" ImageUrl="~/images/scissors.png" Width="80px" OnClick="ImgBtnScissors_Click" />
            <br />
        </div>
    </form>
</body>
</html>
