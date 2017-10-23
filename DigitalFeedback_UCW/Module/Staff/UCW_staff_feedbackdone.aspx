<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_feedbackdone.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_feedbackdone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell Width="40%" CssClass="lbl_1"><asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label></asp:TableCell>
            <asp:TableCell Width="10%" ><asp:Image ID="Image1" runat="server" ImageUrl="~/img/feedback/fd_right.png" /></asp:TableCell>
            <asp:TableCell Width="10%" ><asp:Image ID="Image4" runat="server" ImageUrl="~/img/feedback/fd_r.png" Visible="false" /></asp:TableCell>
            <asp:TableCell Width="40%" ><asp:Label ID="Label4" runat="server" Text=""></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><br /><br /></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1"><asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Image ID="Image2" runat="server" ImageUrl="~/img/feedback/fd_right.png" Visible="false" /></asp:TableCell>
            <asp:TableCell><asp:Image ID="Image5" runat="server" ImageUrl="~/img/feedback/fd_r.png" Visible="false" /></asp:TableCell>
            <asp:TableCell CssClass="lbl_6"><asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Visible="false"><< Quiz >></asp:LinkButton></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><br /><br /></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1"><asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Image ID="Image3" runat="server" ImageUrl="~/img/feedback/fd_right.png" Visible="false" /></asp:TableCell>
            <asp:TableCell><asp:Image ID="Image6" runat="server" ImageUrl="~/img/feedback/fd_r.png" Visible="false" /></asp:TableCell>
            <asp:TableCell CssClass="lbl_6"><asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><br /><br /></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_1"></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/back.png" OnClick="ImageButton1_Click" ImageAlign="Right" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
