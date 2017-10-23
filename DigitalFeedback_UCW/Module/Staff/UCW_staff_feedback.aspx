<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_feedback.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_feedback" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <br />
    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3" CssClass="lbl_2">1. The <font color = 'red'>Duration</font> of the event/activity was :</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3" CssClass="lbl_3">Tempoh acara di anjurkan adalah :</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">
                <br />
                <br />
                <br />
                <br />
                <br />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="btn1" runat="server" ImageUrl="~/img/feedback/fb_btn_set1_a.png" OnClick="btn1_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn2" runat="server" ImageUrl="~/img/feedback/fb_btn_set1_b.png" OnClick="btn2_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn3" runat="server" ImageUrl="~/img/feedback/fb_btn_set1_c.png" OnClick="btn3_Click"></asp:ImageButton></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
