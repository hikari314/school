<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="forcaweb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Jogo da Forca</title>
    <style>
        div.lol{
            text-align:center;
            margin-top:30px;
            flex-direction: column;
           
            
        }

        div.um{
            
            float: left;
        }

         div.dois{
            
             float: left;
             margin-top: 100px;
             text-align:left;
             
        }

          div.tres{
            
             float: left;
             margin-top: 340px;
        }

          div.quatro{
             
             float: left;
          }

          div.cinco{
              text-align: center;
              margin-top: 100px;

          }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="lol">
            <h1>Jogo da forca</h1>

            <div class="um"> 

            <asp:Image ID="Image1" runat="server" ImageUrl="~/image/forca.png" Width="237px" Height="423px" />

          </div>

            <div class="dois">

            <asp:Image ID="img1" runat="server" ImageUrl="~/image/cabeca.png" Visible= "false"  />
           <br />
              <asp:Image ID="img2" runat="server" ImageUrl="~/image/braco1.png" Visible= "false" /> 
              <asp:Image ID="img3" runat="server" ImageUrl="~/image/tronco1.png"  Visible= "false"/> 
              <asp:Image ID="img4" runat="server" ImageUrl="~/image/braco2.png"  Visible= "false"/> 
           <br />
              <asp:Image ID="img5" runat="server" ImageUrl="~/image/perna1.png" Visible= "false" /> 
              <asp:Image ID="img6" runat="server" ImageUrl="~/image/perna2.png" Visible= "false" /> 
            
             </div>

            <div class="tres">

                <asp:Label ID="lbl1" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
                 <asp:Label ID="lbl2" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
                 <asp:Label ID="lbl3" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
                 <asp:Label ID="lbl4" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
                 <asp:Label ID="lbl5" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
                 <asp:Label ID="lbl6" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" BorderStyle="Groove"></asp:Label> &ensp;
       

            </div>

            <div class="quatro">

                <h2>Letras erradas
                <asp:Label ID="qerros" runat="server" Text="0" Visible="false" ></asp:Label></h2>
                <asp:Label ID="erros" runat="server" Text=" "></asp:Label>

            </div> 

            <div class="seis">
                <h3>Dica:
                    <asp:Label ID="lbldica" runat="server" Text="Fruta"></asp:Label>
                    <asp:Label ID="letra1" runat="server" Text="B" Visible="false"></asp:Label>
                    <asp:Label ID="letra2" runat="server" Text="A" Visible="false"></asp:Label>
                    <asp:Label ID="letra3" runat="server" Text="N" Visible="false"></asp:Label>
                    <asp:Label ID="letra4" runat="server" Text="A" Visible="false"></asp:Label>
                    <asp:Label ID="letra5" runat="server" Text="N" Visible="false"></asp:Label>
                    <asp:Label ID="letra6" runat="server" Text="A" Visible="false"></asp:Label>
                </h3>
                <asp:Button ID="btnSortaar" runat="server" Text="Sortear"  Font-Size="20pt" OnClick="btnSortaar_Click" />
            </div>

            </div> 

        <div class="cinco">

            <asp:TextBox ID="txtletra" runat="server" Font-Size="50pt" Width="50px" MaxLength="1" AutoComplete="false" ></asp:TextBox> <br /> &ensp; <br />
            <asp:Button ID="btnconfere" runat="server" Text="Conferir" Font-Size="20pt" OnClick="btnconfere_Click"  /> &ensp;
            <asp:Button ID="btnlimpar" runat="server" Text="Reiniciar" Font-Size="20pt" OnClick="btnlimpar_Click" />

        </div>

    </form>
</body>
</html>
