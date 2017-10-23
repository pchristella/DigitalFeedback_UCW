<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_nonstaff_feedbackq5.aspx.cs" Inherits="DigitalFeedback_UCW.Module.NonStaff.UCW_nonstaff_feedbackq5" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <br />
        <br />
        <br />
     <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_2">5. What did you <font color="red">like</font> about the event?</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_3">Apakah perkara yang anda <font color="red">gemari</font> di dalam program ini?</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <br />
                <br />              
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:TextBox ID="txt_5" runat="server" Height="241px" TextMode="MultiLine" Width="970px" Font-Size="35px"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/next.png" OnClick="ImageButton1_Click" ImageAlign="Right" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
