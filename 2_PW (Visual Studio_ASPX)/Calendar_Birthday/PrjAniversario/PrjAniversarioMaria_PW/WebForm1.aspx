<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrjAniversarioMaria_PW.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><center>
            <asp:Label ID="Label1" runat="server" Text="Aniversários" Font-Size="30px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome do Aniversariante:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Insira a data de nascimento:"></asp:Label>
            <br />
            <asp:Calendar ID="C1" runat="server">
            </asp:Calendar>
            <br />
            <asp:Button ID="btnC" runat="server" Text="Cadastrar" OnClick="btnC_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnM" runat="server" Text="Mostrar" OnClick="btnM_Click" />
            <br />
            <br />
            <asp:Label ID="lblMostar" runat="server" Text=""></asp:Label>
        </center></div>
    </form>
</body>
</html>
