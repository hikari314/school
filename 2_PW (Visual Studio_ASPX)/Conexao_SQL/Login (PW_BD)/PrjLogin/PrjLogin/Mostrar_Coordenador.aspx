<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mostrar_Coordenador.aspx.cs" Inherits="PrjLogin.Mostrar_Coordenador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consulta - Coordenador</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="a">
            <div class="principal">
                <div class="header">
                    <asp:Label ID="Label21" runat="server" Text="Consulta" Font-Bold="true" Font-Size="19px"></asp:Label>
                </div>
            
            <br />
            <asp:Label ID="Label1" runat="server" Text="Pesquise os Pedidos entregues no mês e ano inseridos abaixo:" Font-Size="20px"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtResposta" runat="server" Width="217px" TextMode="Month" Font-Size="15px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnPesquisar" runat="server" CssClass="basico" Text="Pesquisar" OnClick="btnPesquisar_Click" Height="42px" Width="140px" />
            <br />
            <br />
            <asp:GridView ID="gvCM" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
            <asp:Button ID="Button1" runat="server" Text="Voltar" CssClass="basico" OnClick="Button1_Click" Height="42px" Width="90px" />
            <br />
            </div>


        </div>
    </form>
</body>
</html>
