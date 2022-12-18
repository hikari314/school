<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorldG.aspx.cs" Inherits="PrjQuiz_Maria_2DS.WorldG" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h3 class="header">Welcome to the Quiz of World Geography!</h3></center>

            <div>
                <div>
                    <p class="pquestionsall">1)  Which country has the most islands in the world?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt1" runat="server" Text="Indonesia"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt2" runat="server" Text="Sweden-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt3" runat="server" Text="Singapore"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt4" runat="server" Text="Fiji"/>
                </div>

                <div>
                    <p class="pquestionsall">2) What is the smallest country in the world? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt5" runat="server" Text="Vatican-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt6" runat="server" Text="Monaco"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt7" runat="server" Text="Maldives"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt8" runat="server" Text="San Marino"/>
                </div>

                <div>
                    <p class="pquestionsall">3) What is the capital of Canada?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt9" runat="server" Text="Dublin"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt10" runat="server" Text="Sofia"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt11" runat="server" Text="Ottawa-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt12" runat="server" Text="Nassau"/>
                </div>

                <div>
                    <p class="pquestionsall">4) What is the longest mountain range in the world?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt13" runat="server" Text="Southern Great Escarpment"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt14" runat="server" Text="Mount Everest"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt15" runat="server" Text="Andes-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt16" runat="server" Text="Kangchenjunga"/>
                </div>

                <div>
                    <p class="pquestionsall">5) Where is the lowest natural place on planet Earth? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt17" runat="server" Text="Death Velley"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt18" runat="server" Text="Laguna del Carbón"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt19" runat="server" Text="Dead Sea"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt20" runat="server" Text="Mariana Trench-"/>
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
