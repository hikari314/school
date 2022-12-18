<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FinishArt.aspx.cs" Inherits="PrjQuiz_Maria_2DS.FinishArt" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center><h1>
                <asp:Label class="header" ID="Label1" runat="server" Text="It's finished!"></asp:Label>
            </h1></center>
            
            <div class="divresultall">
                <asp:Label ID="Label2" runat="server" Text=" You guessed right: "></asp:Label>
                <asp:Label class="lblresultall" ID="LblAnswer" runat="server" Text="0"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="%"></asp:Label>
                <br />
                <br />
                
                <div class="divImageFinal">
                    <asp:Image ID="Image" runat="server" ImageUrl="~/images/back.jpg" />
                    <br />
                    <br />
                </div>
                <asp:Button class="allbutton" ID="btnAgain" runat="server" Text="Play Again" OnClick="btnAgain_Click" />
        </div>
            </div>
    </form>
</body>
</html>
