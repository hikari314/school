﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Q10.aspx.cs" Inherits="PrjQuiz02.Q10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <left><h3>
                ...
            </h3>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/lilo.png" Width="700px" Height="500px" />
            <br />
            </left>
            <br />
            <asp:RadioButton ID="RdoOpt1" GroupName="Opt" runat="server" Text="Lilo & Stitch" />
            <br />
            <asp:RadioButton ID="RdoOpt2" GroupName="Opt" runat="server" Text="The Lady and The Tramp" />
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
        </div>
    </form>
</body>
</html>
