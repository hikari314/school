<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InserirDados.aspx.cs" Inherits="PrjInsert.InserirDados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label><br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label><br />
            <asp:TextBox ID="txtFone" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" /><br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
