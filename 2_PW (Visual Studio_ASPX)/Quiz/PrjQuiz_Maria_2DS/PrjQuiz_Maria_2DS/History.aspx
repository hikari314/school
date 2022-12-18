<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="PrjQuiz_Maria_2DS.History" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h3 class="header">Welcome to the Quiz of History and Fashion!</h3></center>

            <div>
                <div>
                    <p class="pquestionsall">1) When was Vogue first published?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt1" runat="server" Text="1960"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt2" runat="server" Text="1892-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt3" runat="server" Text="1961"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt4" runat="server" Text="2000"/>
                </div>

                <div>
                    <p class="pquestionsall">2) What happened on July 20, 1969?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt5" runat="server" Text="Apollo 11 landed on the moon-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt6" runat="server" Text="First Super Bowl Sunday"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt7" runat="server" Text="United States of America Independence Day"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt8" runat="server" Text="Assassination of John F. Kennedy"/>
                </div>

                <div>
                    <p class="pquestionsall">3) Who invented the iconic Little Black Dress?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt9" runat="server" Text="Mary Quant"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt10" runat="server" Text="Louis Reard"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt11" runat="server" Text="Coco Chanel-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt12" runat="server" Text="Mary Phelps Jacob’s"/>
                </div>

                <div>
                    <p class="pquestionsall">4) Who invented the WWW (World Wide Web)?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt13" runat="server" Text="Steve Chen"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt14" runat="server" Text="Larry Page"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt15" runat="server" Text="Tim Berners-Lee-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt16" runat="server" Text="Jack Dorsey"/>
                </div>

                <div>
                    <p class="pquestionsall">5) When did the London Underground open? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt17" runat="server" Text="1902"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt18" runat="server" Text="1892"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt19" runat="server" Text="1874"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt20" runat="server" Text="1863-"/>
                </div>
            </div>

            <br />
            <asp:Button class="allbutton" ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
            &nbsp;
            <asp:Button class="allbutton" ID="btnSeeResults" runat="server" Text="See Results!" OnClick="btnSeeResults_Click" />

        </div>
    </form>
</body>
</html>
