<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Finish.aspx.cs" Inherits="PrjQuiz02.Finish" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>
                <asp:Label ID="Label1" runat="server" Text="It's finished!"></asp:Label>
            </h1></center>
            
            <asp:Label ID="Label2" runat="server" Text=" You guessed right: "></asp:Label>
            <asp:Label ID="LblAnswer" runat="server" Text="0"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="%"></asp:Label>
            <br />
            <br />
            <center>
            <asp:Image ID="Image" runat="server" Width="700px" Height="300px"/>
            </center>
        </div>
    </form>
</body>
</html>
