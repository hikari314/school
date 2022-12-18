<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="PrjCalculadorsaSimples__0223_.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="dig0" runat="server" Text="Calculadora Simples"></asp:Label><br /><br />

        <asp:Label ID="dig1" runat="server" Text="Digite o 1° Valor"></asp:Label><br />
        <asp:TextBox ID="txtVal1" runat="server"></asp:TextBox><br /><br />

        <asp:Label ID="dig2" runat="server" Text="Digite o 2° Valor"></asp:Label><br />
        <asp:TextBox ID="txtVal2" runat="server"></asp:TextBox><br /><br />

        <asp:Label ID="dig3" runat="server" Text="Total"></asp:Label>&nbsp
        <asp:Label ID="lblTotal" runat="server" Text="#"></asp:Label><br /><br />

        <asp:Button ID="btnSoma" runat="server" Text="Soma" Height="28px" Width="54px" OnClick="btnSoma_Click" />&nbsp
        <asp:Button ID="btnSubtrair" runat="server" Text="Subtrair" Height="28px" OnClick="btnSubtrair_Click" Width="76px" /><br />
        <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar" Height="28px" OnClick="btnMultiplicar_Click" Width="98px" />&nbsp
        <asp:Button ID="btnDividir" runat="server" Text="Dividir" Height="28px" OnClick="btnDividir_Click" Width="60px" />&nbsp
        <asp:Button ID="btnSeno" runat="server" Text="Seno" Height="27px" OnClick="btnSeno_Click" Width="59px" />
    </div>
    </form>
</body>
</html>
