<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_nonstaff_quizdone.aspx.cs" Inherits="DigitalFeedback_UCW.Module.NonStaff.UCW_nonstaff_quizdone" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    
        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2"><div align="center">Your Score IS !!!</div></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2"><div align="center"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2"><div align="center"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2"><div align="center"><asp:Label ID="Label3" runat="server" Text="Label" Visible="false"></asp:Label>&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/retry.png" OnClick="ImageButton1_Click" Visible="false" /></div></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow HorizontalAlign="Right">
                <asp:TableCell><asp:ImageButton ID="ImageButton2" ImageUrl="~/img/back.png" PostBackUrl="~/Default.aspx" runat="server" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
