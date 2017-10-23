<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_luckydraw_loading.aspx.cs" Inherits="DigitalFeedback_UCW.Module.LuckyDraw.UCW_luckydraw_loading" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center"><asp:Image ID="Image1" runat="server" ImageUrl="~/img/Loading-Top-Wallpapers.gif" Height="500px" Width="500px"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell HorizontalAlign="Center" CssClass="lbl_1">
                    <div align="center">Selecting the Winner..</div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
        <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick">
        </asp:Timer>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </asp:Content>