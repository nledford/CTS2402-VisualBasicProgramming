<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Exercise9._2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rough Riders Rodeo | Purchase Tickets</title>
    <style type="text/css">
        body, table, h1, h3 
        {
            font-family: Verdana,sans-serif;
            text-align: center;
        }
        
        table 
        {
            font-size: 12px;
            margin: 0 auto 0 auto;
            border: 1px solid #990000;
            padding: 5px;
            background-color: #AA0000;
            color: White;
        }
        
        .orderConfirm 
        {
            text-decoration: none;
            color: white;
            font-size: 14px;
        }
        
        .orderConfirm:hover
        {
            color: #EEEEEE;
        }
    </style>
</head>
<body style="background-color: Red;">
    <form id="form1" runat="server">
    <h1>Rough Riders Rodeo</h1>

    <h3>Rodeo Tickets Order Form</h3>

    <table id="TicketsOrderForm">
        <tr>
            <td align="right">Number of Tickets:</td>
            <td align="left">
                <asp:TextBox ID="UserTickets" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="TicketsValidator" runat="server" 
                    ControlToValidate="UserTickets" ErrorMessage="Number of Tickets are required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td style="text-align: left;">
                <asp:CheckBox ID="AwardsCheckBox" runat="server" />
                Awards Event
            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center; font-weight: bold;">Payment Information</td>
        </tr>

        <tr>   
            <td align="right">Credit Card Number:</td>
            <td align="left">
                <asp:TextBox ID="UserCreditCard" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CreditCardValidator" runat="server" 
                    ControlToValidate="UserCreditCard" 
                    ErrorMessage="Credit Card Number is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td align="right">Expiration Date:</td>
            <td align="left">
                <asp:TextBox ID="UserExpiration" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ExpirationValidator" runat="server" 
                    ControlToValidate="UserExpiration" ErrorMessage="Expiration Date is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td align="right">Type:</td>
            <td align="left">
                &nbsp;<asp:DropDownList ID="CreditCardList" runat="server">
                    <asp:ListItem>MasterCard</asp:ListItem>
                    <asp:ListItem>American Express</asp:ListItem>
                    <asp:ListItem>Visa</asp:ListItem>
                    <asp:ListItem>Food Stamps</asp:ListItem>
                    <asp:ListItem>Reddit Karma</asp:ListItem>
                    <asp:ListItem>XBox Live Gamerscore</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center; font-weight: bold;">Shipping Information</td>
        </tr>

        <tr>
            <td align="right">Address</td>
            <td align="left">
                <asp:TextBox ID="UserAddress" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="AddressValidator" runat="server" 
                    ControlToValidate="UserAddress" ErrorMessage="Address is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td align="right">City</td>
            <td align="left">
                <asp:TextBox ID="UserCity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="CityValidator" runat="server" 
                    ControlToValidate="UserCity" ErrorMessage="City is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td align="right">State</td>
            <td align="left">
                <asp:TextBox ID="UserState" runat="server" MaxLength="2"></asp:TextBox>
                <asp:RequiredFieldValidator ID="StateValidator" runat="server" 
                    ControlToValidate="UserState" ErrorMessage="State is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td align="right">Zip</td>
            <td align="left">
                <asp:TextBox ID="UserZip" runat="server" MaxLength="5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ZipValidator" runat="server" 
                    ControlToValidate="UserZip" ErrorMessage="Zip is required"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td>&nbsp;</td>
            <td style="text-align: left;">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit Order" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="OrderTotalLabel" runat="server" Text="Order Total:"></asp:Label>
            </td>
        </tr>

        <tr>
            <td colspan="2"> 
                <asp:HyperLink ID="OrderConfirmLink" runat="server" Visible="False" 
                    NavigateUrl="~/Confirmation.aspx" CssClass="orderConfirm">Order Confirmation</asp:HyperLink>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
