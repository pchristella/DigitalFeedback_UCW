<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DigitalFeedback_UCW._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
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
    <div>
        <asp:Table runat="server" Width="100%">
            <asp:TableRow><asp:TableCell ColumnSpan="2" HorizontalAlign="Center"><asp:Image ID="Image1" runat="server" ImageUrl="~/img/title.png" /></asp:TableCell></asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <br />
        <br />
        <br />
        <br />
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width="50%" HorizontalAlign="Center"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/staff.png" OnClick="ImageButton1_Click" /></asp:TableCell>
                <asp:TableCell Width="50%" HorizontalAlign="Center"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/img/nonstaff.png" OnClick="ImageButton2_Click" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Module/CheckOut/UCW_checkout_list.aspx">...</asp:LinkButton>&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Module/Other/DB_Upload.aspx">...</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Module/LuckyDraw/UCW_luckydraw_main.aspx">...</asp:LinkButton>
        </div>
</asp:Content>
