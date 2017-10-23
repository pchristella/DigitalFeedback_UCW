<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_feedbackq6.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_feedbackq6" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    
    <br />
        <br />
        <br />
     <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_2">6. <font color="red">Suggestion</font> for improvement (if any)</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_3">Cadangan-cadangan untuk penambahbaikkan (jika ada)</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <br />
                <br />              
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:TextBox ID="txt_6" runat="server" Height="218px" TextMode="MultiLine" Width="970px" Font-Size="35px"></asp:TextBox></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/next.png" OnClick="ImageButton1_Click" ImageAlign="Right" /></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
