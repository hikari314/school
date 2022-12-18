<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BDay.aspx.cs" Inherits="PrjCalculateBDay.BDay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Select your birth date:"></asp:Label>
            <br />
            <asp:Calendar ID="calendarBDay" runat="server" OnSelectionChanged="calendarBDay_SelectionChanged" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Check your birth date:"></asp:Label>
            <br />
            <asp:TextBox ID="txtBDay" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCal" runat="server" Text="Calculate" OnClick="btnCal_Click" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
