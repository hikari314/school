<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Procedimento.aspx.cs" Inherits="PrjProcedimento.Procedimento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="l" runat="server" Text="Usuário:"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lb" runat="server" Text="Senha:"></asp:Label>
            <br />
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnExecutar" runat="server" Text="Executar" OnClick="btnExecutar_Click" />
            <br />
            <br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtFone" runat="server"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
