﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_nonstaff_iccheck.aspx.cs" Inherits="DigitalFeedback_UCW.Module.NonStaff.UCW_nonstaff_iccheck" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
          
    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell Width="20%" CssClass="lbl_1">NO IC /Passport :</asp:TableCell>
            <asp:TableCell Width="80%" CssClass="lbl_1" VerticalAlign="Middle"><div style="align-items:center;"><asp:TextBox ID="txt_icno" runat="server" Height="100px" Width="400px" Font-Size="45px"></asp:TextBox>&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/img/check.png" ImageAlign="Middle" /></div></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Name / Nama : </asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_name" runat="server" Height="100px" Width="778px" Font-Size="45px" Enabled="false"></asp:TextBox>&nbsp;</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Company / Kompeni :</asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_com" runat="server" Height="100px" Width="778px" Font-Size="45px" Enabled="false"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1">Tel No :</asp:TableCell>
            <asp:TableCell CssClass="lbl_1"><asp:TextBox ID="txt_telno" runat="server" Height="100px" Width="378px" Font-Size="45px" Enabled="false"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_telno" ErrorMessage="Phone Number is not valid" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                &nbsp;</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell CssClass="lbl_error"><asp:Label ID="lbl_error" runat="server" Text="Label" Visible="false"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2"><asp:ImageButton runat="server" ImageUrl="~/img/next.png" ID="ImageButton2" OnClick="ImageButton2_Click" ImageAlign="Right"></asp:ImageButton></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
