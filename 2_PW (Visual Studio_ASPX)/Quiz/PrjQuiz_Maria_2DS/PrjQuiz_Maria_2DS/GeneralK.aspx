<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneralK.aspx.cs" Inherits="PrjQuiz_Maria_2DS.GeneralK" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h3 class="header">Welcome to the Quiz of General Knowledge!</h3></center>

            <div>
                <div>
                    <p class="pquestionsall">1) How many time zones are there in Russia?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt1" runat="server" Text="10"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt2" runat="server" Text="11-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt3" runat="server" Text="12"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt4" runat="server" Text="13"/>
                </div>

                <div>
                    <p class="pquestionsall">2) What is the national flower of Japan?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt5" runat="server" Text="Sakura (Cherry Blossom)-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt6" runat="server" Text="Tsubaki (Camellia)"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt7" runat="server" Text="Sakurasou (Japanese Primrose)"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt8" runat="server" Text="Ume (Apricot Tree Blossom)"/>
                </div>

                <div>
                    <p class="pquestionsall">3) What is Australia's national animal?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt9" runat="server" Text="Kangaroo"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt10" runat="server" Text="Platypus"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt11" runat="server" Text="Red Kangaroo-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt12" runat="server" Text="Dingo"/>
                </div>

                <div>
                    <p class="pquestionsall">4) Which of the following Empires does not have a written language?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt13" runat="server" Text="Aztec"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt14" runat="server" Text="Egyptian"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt15" runat="server" Text="Inca-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt16" runat="server" Text="Roman"/>
                </div>

                <div>
                    <p class="pquestionsall">5) Until 1923, what was the Turkish city of Istanbul called? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt17" runat="server" Text="Petra"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt18" runat="server" Text="Memphis"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt19" runat="server" Text="Pompeii"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt20" runat="server" Text="Constantinople-"/>
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
