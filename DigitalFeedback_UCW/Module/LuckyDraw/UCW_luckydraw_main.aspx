<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="UCW_luckydraw_main.aspx.cs" Inherits="DigitalFeedback_UCW.Module.LuckyDraw.UCW_luckydraw_main" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        
        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell CssClass="lbl_2" ColumnSpan="2">
                    <div align="center">UCW17 Lucky Draw</div>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2">
                    <br />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width="50%" HorizontalAlign="Center">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/staff.png" OnClick="ImageButton1_Click" ImageAlign="Middle" />
                </asp:TableCell>
                <asp:TableCell Width="50%" HorizontalAlign="Center">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/nonstaff.png" OnClick="ImageButton2_Click" ImageAlign="Middle"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
