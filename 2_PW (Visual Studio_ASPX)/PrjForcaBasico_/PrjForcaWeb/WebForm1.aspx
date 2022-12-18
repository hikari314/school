<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrjForcaWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div Style="text-align:center">
            <asp:Image ID="ImgCabeca" runat="server"  /><br />
            <asp:Image ID="ImgTronco" runat="server"  /><br />
            <asp:Image ID="ImgPernas" runat="server" /><br />
            <asp:Label ID="Lblpalavra" runat="server" Text="Digite uma palavra de três letras!" Font-Size="16pt"></asp:Label><br />
            <asp:TextBox ID="TxtResposta" runat="server" MaxLength="3" Font-Size="16pt" Style="margin:10px;text-align:center" Width="110px"></asp:TextBox><br />
            <asp:Button ID="BtnVerificar" runat="server" Text="Verificar" OnClick="BtnVerificar_Click" Font-Size="16pt" Height="37px" Width="111px" />

        </div>
    </form>
</body>
</html>
