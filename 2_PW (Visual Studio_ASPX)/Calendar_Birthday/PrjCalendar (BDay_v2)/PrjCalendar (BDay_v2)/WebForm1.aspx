<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrjCalendar__BDay_v2_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                Width="200px" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
            <asp:TextBox ID="txtBDAY" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCheck" runat="server" Text="Check" 
                OnClick="btnCheck_Click" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="#"></asp:Label>
        </div>
    </form>
</body>
</html>
