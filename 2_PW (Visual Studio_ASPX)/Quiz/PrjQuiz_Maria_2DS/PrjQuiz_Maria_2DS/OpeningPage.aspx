<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OpeningPage.aspx.cs" Inherits="PrjQuiz_Maria_2DS.OpeningPage" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h2 class="header">Welcome to the Quiz!</h2></center>

            <p class="pwelcome">Welcome to Quiz! In this game, you can choose from one of the options below and enjoy questions related to the topic you are most knowledgeable about!
            Each option below will provide 5 questions about the related topic. Try to answer them correctly!
            As a rule of the game, don't leave the page and try to find the answers on the internet, as that would lose the fun.
            Enjoy the game and good luck!</p>
            
            <div class="button">
            &nbsp;
            <asp:Button class="allbutton" ID="btnGeneral" runat="server" Text="General Knowledge" OnClick="btnGeneral_Click" />
            &nbsp;
            <asp:Button class="allbutton" ID="btnWorld" runat="server" Text="World Geography" OnClick="btnWorld_Click" />
            &nbsp;
            <asp:Button class="allbutton" ID="btnArt" runat="server" Text="Language, Literature & Art" OnClick="btnArt_Click" />
            &nbsp;
            <asp:Button class="allbutton" ID="btnHistory" runat="server" Text="History & Fashion" OnClick="btnHistory_Click" />
            &nbsp;
            <asp:Button class="allbutton" ID="btnPop" runat="server" Text="Pop Culture & Music" OnClick="btnPop_Click" />
            </div>
        </div>
    </form>
</body>
</html>
