<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Postal_Code_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Width:<asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="widthTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            Height:<asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="heightTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            Length:<asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="lengthTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="shipGroup" OnCheckedChanged="groundRadioButton_CheckedChanged" Text="Ground" />
        </p>
        <p>
            <asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="shipGroup" OnCheckedChanged="airRadioButton_CheckedChanged" Text="Air" />
        </p>
        <p>
            <asp:RadioButton ID="nextRadioButton" runat="server" AutoPostBack="True" GroupName="shipGroup" OnCheckedChanged="nextRadioButton_CheckedChanged" Text="Next Day" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
