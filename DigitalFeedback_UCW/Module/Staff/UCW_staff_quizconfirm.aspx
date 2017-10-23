<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_quizconfirm.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_quizconfirm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_2">Are you sure with your answer?</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_5">
                Your answer is <br/>
                1. <asp:Label ID="lbl_qs1" runat="server" Text="Label"></asp:Label><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br/>
                2. <asp:Label ID="lbl_qs2" runat="server" Text="Label"></asp:Label><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br/>
                3. <asp:Label ID="lbl_qs3" runat="server" Text="Label"></asp:Label><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br/>
                4. <asp:Label ID="lbl_qs4" runat="server" Text="Label"></asp:Label><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br/>
                5. <asp:Label ID="lbl_qs5" runat="server" Text="Label"></asp:Label><br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br/>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:Label runat="server" CssClass="lbl_1" ForeColor="Red" Text="Label" ID="lbl_1"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/submit.png" OnClick="ImageButton1_Click" ImageAlign="Right"/>&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/prev.png" OnClick="ImageButton2_Click" ImageAlign="Right" />&nbsp;</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
