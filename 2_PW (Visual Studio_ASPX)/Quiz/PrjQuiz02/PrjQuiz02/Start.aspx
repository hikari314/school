<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="PrjQuiz02.WebForm1" %>

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
                Welcome to the Quiz! 
            </h1></center>
            <p>
                Can you figure out which Disney movie is just by looking at the sets?
                The Disney classics are all unforgettable... but do you pay attention to every detail?
                Observe these scenarios and answer: which movie is it from?
            </p>
            <asp:Label ID="Label1" runat="server" Text="Which movie is it from?"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image2" runat="server" ImageUrl="~/images/aladdin.png" Width="700px" Height="500px"/>
            <br />
            <br />
            <asp:RadioButton ID="RdoOpt1" GroupName="Opt" runat="server" Text="Aladdin" />
            <br />
            <asp:RadioButton ID="RdoOpt2" GroupName="Opt" runat="server" Text="Hercules" />
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" Text="Next" OnClick="BtnNext_Click" />
            
        </div>
    </form>
</body>
</html>
