<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site2.Master" CodeBehind="UCW_checkout_view_staff.aspx.cs" Inherits="DigitalFeedback_UCW.Module.CheckOut.UCW_checkout_view_staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell Width="30%">Name :</asp:TableCell>
            <asp:TableCell Width="70%"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width="30%">Staff ID :</asp:TableCell>
            <asp:TableCell Width="70%"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width="30%">Feedback :</asp:TableCell>
            <asp:TableCell Width="70%"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width="30%">Quiz :</asp:TableCell>
            <asp:TableCell Width="70%"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell Width="30%">Checkout :</asp:TableCell>
            <asp:TableCell Width="70%"><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
