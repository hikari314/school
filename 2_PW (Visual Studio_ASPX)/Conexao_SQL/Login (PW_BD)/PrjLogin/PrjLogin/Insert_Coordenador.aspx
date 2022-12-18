<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Coordenador.aspx.cs" Inherits="PrjLogin.Insert_Coordenador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Insert - Coordenador</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="b">
            <div class="insert">
                <div class="header">
                    <asp:Label ID="Label14" runat="server" Text="Inserir dados na tabela Pedidos:" Font-Bold="true" Font-Size="19px"></asp:Label>

                </div>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Número do Pedido:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtNumped" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label16" runat="server" Text="Código do Cliente:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtCodcli" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Código do Funcionário:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtCodfun" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label18" runat="server" Text="Data do Pedido:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtDataped" runat="server" TextMode="Date" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label19" runat="server" Text="Data de Entrega:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtDataentrega" runat="server" TextMode="Date" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label20" runat="server" Text="Frete:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtFrete" runat="server" Font-Size="15px"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="btnInsert" runat="server" CssClass="basico" Text="Insert" OnClick="btnInsert_Click" Height="42px" Width="90px" />

            <br />
            <br />
            <asp:GridView ID="gvC" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>

            <br />
            <asp:Button ID="btnVoltar" runat="server" CssClass="basico" Text="Voltar" OnClick="btnVoltar_Click" Height="42px" Width="90px" />
            </div>
        </div>
    </form>
</body>
</html>
