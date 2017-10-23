<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_luckydraw_result_nonstaff.aspx.cs" Inherits="DigitalFeedback_UCW.Module.LuckyDraw.UCW_luckydraw_result_nonstaff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>    
        <br />
        <br />
        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_2">
                    ** The Winner Is **
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_2">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_2">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_2">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_2">
                    ** Congratulations **
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/back.png" OnClick="ImageButton1_Click" ImageAlign="Right" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
