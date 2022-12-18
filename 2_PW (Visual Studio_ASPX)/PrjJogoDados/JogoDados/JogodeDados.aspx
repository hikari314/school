<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JogodeDados.aspx.cs" Inherits="JogoDados.JogodeDados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>
        div.maria{
            margin-top:30px;
            margin-left:30px;
            text-align:center;
        }


    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div class="maria">

            <asp:Image ID="Image" runat="server" Height="300px" Width="300px" ImageUrl="~/image/dado1.png" BorderStyle="Solid" />

            <br />
            <br />

            <asp:Button  Height="75px" Width="200px" font-size="30px" ID="BtnSortear" runat="server" Text="Sortear" OnClick="BtnSortear_Click" BackColor="Aqua" BorderStyle="Solid" ForeColor="Black" />

        </div>
    </form>
</body>
</html>
