<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pop.aspx.cs" Inherits="PrjQuiz_Maria_2DS.Pop" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h3 class="header">Welcome to the Quiz of Pop, Music and Culture!</h3></center>

            <div>
                <div>
                    <p class="pquestionsall">1) Which city did the Beatles come from?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt1" runat="server" Text="London"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt2" runat="server" Text="Liverpool-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt3" runat="server" Text="Bristol"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt4" runat="server" Text="Manchester"/>
                </div>

                <div>
                    <p class="pquestionsall">2) What is the most played song on Spotify of all time so far?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt5" runat="server" Text="Ed Sheeran, The Shape of You-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt6" runat="server" Text="The Weeknd, Blinding Lights"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt7" runat="server" Text="Tones and I, Dance Monkey"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt8" runat="server" Text="Post Malone, Rockstar"/>
                </div>

                <div>
                    <p class="pquestionsall">3) How many keys are there on a classical piano?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt9" runat="server" Text="86"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt10" runat="server" Text="87"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt11" runat="server" Text="88-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt12" runat="server" Text="89"/>
                </div>

                <div>
                    <p class="pquestionsall">4) Where is Lady Gaga from?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt13" runat="server" Text="New Jersey"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt14" runat="server" Text="Los Angeles"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt15" runat="server" Text="New York-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt16" runat="server" Text="Brooklyn"/>
                </div>

                <div>
                    <p class="pquestionsall">5) Which famous American band was originally called “Kara's Flowers”? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt17" runat="server" Text="Boston"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt18" runat="server" Text="Red Hot Chili Peppers"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt19" runat="server" Text="Nirvana"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt20" runat="server" Text="Maroon 5-"/>
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
