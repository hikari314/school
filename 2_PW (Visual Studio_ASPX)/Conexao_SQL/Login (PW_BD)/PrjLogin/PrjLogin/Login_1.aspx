<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_1.aspx.cs" Inherits="PrjLogin.Login_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="a">

            <div class="principal">
                <div class="header">
                    <asp:Label ID="Label1" CssClass="lbl1" runat="server" Font-Bold="true" Text="Login"></asp:Label>
                </div>
                
                <br />
                <asp:Label ID="Label10" runat="server" font-size="20px" Text="Usuário:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtUsuario" Font-Size="15px" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label11" font-size="20px" runat="server" Text="Senha:"></asp:Label>
                &nbsp;<asp:TextBox ID="txtSenha" Font-Size="15px" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" CssClass="log" runat="server" Text="Login" OnClick="Button1_Click" Height="40px" Width="80px" />
                <br />
                &nbsp;
                <div class="divinstru">
                     <asp:Label ID="Label2" runat="server" font-size="20px" Text="O Login e Senha são direcionados ao Gerente e Coordenador da empresa, que terão diferentes tabelas para editarem e acessarem."></asp:Label>
                     <br />
                     <asp:Label ID="Label3" runat="server" font-size="20px" Text="Com a criação de um novo campo (senha - Tabela Funcionarios), esses são os registros necessários para o login:"></asp:Label>
                     <br />
                </div>
            
                <br />
                <asp:Label ID="Label4" runat="server" font-size="20px" Text="Gerente " Font-Italic="true"></asp:Label>
                &nbsp;<br />
                <asp:Label ID="Label6" runat="server" font-size="20px" Text="Usuário: Buchanan |"></asp:Label>
                &nbsp;
                <asp:Label ID="Label7" runat="server" font-size="20px" Text="Senha: Gere7098"></asp:Label>
                <br />
                <br />
                &nbsp;<asp:Label ID="Label5" runat="server" font-size="20px" Text="Coordenador" Font-Italic="true"></asp:Label> &nbsp;
                <br />
                &nbsp;&nbsp;
                <asp:Label ID="Label8" runat="server" font-size="20px" Text="Usuário: Callahan |"></asp:Label>
                &nbsp;
                <asp:Label ID="Label9" runat="server" font-size="20px" Text="Senha: Coor1314"></asp:Label>
            </div>
            <div class="foot">
                <asp:Label ID="Label12" runat="server" font-size="20px" Text="&copy; MEEOC & LDT" Font-Italic="true"></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
