<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Art.aspx.cs" Inherits="PrjQuiz_Maria_2DS.Art" %>

<!DOCTYPE html>
<link href="StyleSheet.css" rel="stylesheet" type="text/css" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h3 class="header">Welcome to the Quiz of Language, Literature & Art!</h3></center>

            <div>
                <div>
                    <p class="pquestionsall">1) What is the best-selling book series of the 21st century?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt1" runat="server" Text="The Hobbit, J. R. R. Tolkien"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt2" runat="server" Text="Harry Potter, JK Rowling-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt3" runat="server" Text="The Hunger Games, Suzanne Collins"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt" ID="RdoOpt4" runat="server" Text="Twilight, Stephenie Meyer"/>
                </div>

                <div>
                    <p class="pquestionsall">2) Which language has the most words (according to dictionaries)?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt5" runat="server" Text="English-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt6" runat="server" Text="Russian"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt7" runat="server" Text="Spanish"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt1" ID="RdoOpt8" runat="server" Text="Chinese"/>
                </div>

                <div>
                    <p class="pquestionsall">3) Norwegian artist Edvard Munch is famous for painting which iconic piece?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt9" runat="server" Text="Girl With a Pearl Earring"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt10" runat="server" Text="The Starry Night"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt11" runat="server" Text="The Scream-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt2" ID="RdoOpt12" runat="server" Text="The Birth of Venus"/>
                </div>

                <div>
                    <p class="pquestionsall">4) Which artist painted the ceiling of the Sistine Chapel in Rome?</p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt13" runat="server" Text="Botticelli"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt14" runat="server" Text="Donatello"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt15" runat="server" Text="Michelangelo-"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt3" ID="RdoOpt16" runat="server" Text="Da Vinci"/>
                </div>

                <div>
                    <p class="pquestionsall">5) What is the slang used by locals to refer to New York City? </p>
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt17" runat="server" Text="King's Landing"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt18" runat="server" Text="Basin City"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt19" runat="server" Text="Hillwood"/>
                    <br />
                    <asp:RadioButton class="radiobutton" GroupName="Opt4" ID="RdoOpt20" runat="server" Text="Gotham-"/>
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
