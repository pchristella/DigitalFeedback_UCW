﻿
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_quizcheck.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_quizcheck" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    
        STAFF ID :
        <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check / Periksa" />
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" PostBackUrl="~/Default.aspx" Text="Back / Kembali" />
    
    </div>
</asp:Content>
