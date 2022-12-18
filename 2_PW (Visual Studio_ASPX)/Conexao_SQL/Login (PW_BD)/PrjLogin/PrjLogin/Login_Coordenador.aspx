<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Coordenador.aspx.cs" Inherits="PrjLogin.Login_Coordenador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bem-vindo!</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="a">

            <div class="principal">
                <div class="header">
                    <asp:Label ID="Label9" runat="server" Text="Bem-vindo!" Font-Size="22px" Font-Bold="true"></asp:Label>
                </div>
            
            <br />

            <asp:Label ID="Label8" runat="server" Text="Login efetuado com sucesso!" font-size="20px"></asp:Label>

            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Escolha sua próxima ação:" font-size="20px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="1 - Inserir Dados (tabela Pedidos)" font-size="20px"></asp:Label>
                <br />
            <br />
            <asp:Button ID="btnInserir" runat="server" Text="Inserir" CssClass="basico" OnClick="btnInserir_Click" Height="42px" Width="90px" />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="2 - Consultar Dados " font-size="20px"></asp:Label>
                <br />
            <br />
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="basico" OnClick="btnConsultar_Click" Height="42px" Width="132px" />
            <br />
            <br />
            </div>
            <div class="foot">
                <asp:Label ID="Label1" runat="server" font-size="20px" Text="&copy; MEEOC & LDT" Font-Italic="true"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
