<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TemperatureConverter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Temperature Converter</h3>
            <br />
            From:&nbsp;
            <asp:DropDownList ID="FromDropDown" runat="server">
                <asp:ListItem>Celsius</asp:ListItem>
                <asp:ListItem>Farenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:
            <asp:DropDownList ID="ToDropDown" runat="server">
                <asp:ListItem>Farenheit</asp:ListItem>
                <asp:ListItem>Kelvin</asp:ListItem>
                <asp:ListItem>Celsius</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Input: <asp:TextBox ID="InputBox" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="InputBox" Display="Dynamic" ErrorMessage="Input is required" Font-Size="Medium" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="InputBox" Display="Dynamic" ErrorMessage="Please enter a number from -1000 to 1000" Font-Size="Medium" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" Type="Double"></asp:RangeValidator>
            <br />
            <br />
            <asp:Button ID="BtnCalculate" runat="server" Text="Calculate" OnClick="BtnCalculate_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnClear" runat="server" Text="Clear" OnClick="BtnClear_Click" />
            <br />
            <br />
            Output: 
            <asp:Label ID="OutputLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
