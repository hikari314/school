<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Gerente.aspx.cs" Inherits="PrjLogin.Insert_Gerente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Insert - Gerente</title>
</head>
<body>
    <form id="form2" runat="server">
        <div class="b">
            <div class="insert">
                <div class="header">
                      <asp:Label ID="Label14" runat="server" Text="Inserir dados na tabela Produtos:" Font-Bold="true" Font-Size="19px"></asp:Label>
                </div>

            <br />
            <asp:Label ID="Label15" runat="server" Text="Código do Produto:" Font-Size="20px"></asp:Label>
                &nbsp;
                <asp:Label ID="Label44" runat="server" Text="Campo Identity" Font-Italic="true" Font-Size="15px"></asp:Label>
        &nbsp;<br />
            <asp:Label ID="Label16" runat="server" Text="Descrição:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtDescr" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Código do Fornecedor:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtCodfor" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label18" runat="server" Text="Código da Categoria:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtCodcategoria" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label19" runat="server" Text="Preço:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtPreco" runat="server" Font-Size="15px"></asp:TextBox>
            <br />
            <asp:Label ID="Label20" runat="server" Text="Unidades:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtUnidades" runat="server" Font-Size="15px"></asp:TextBox>

            <br />
            <asp:Label ID="Label21" runat="server" Text="Descontinuado:" Font-Size="20px"></asp:Label>

        &nbsp;<asp:TextBox ID="txtDescontinuado" runat="server" Font-Size="15px"></asp:TextBox>
                <br />
                <asp:Label ID="Label100" runat="server" Text="OBS.: Preencher o campo acima com 0 ou 1" Font-Size="12px"></asp:Label>
            &nbsp;<br />
            <br />
            <asp:Button ID="btnInsert" runat="server" CssClass="basico" Text="Insert" OnClick="btnInsert_Click" Height="42px" Width="90px" />

            <br />
            <br />
                
            
            <asp:GridView ID="gvG" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
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
