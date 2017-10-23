<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_staff_quiz2.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Staff.UCW_staff_quiz2" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>

        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell ColumnSpan="2" CssClass="lbl_2">2. <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell Width="20%">
                    <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" ImageUrl="~/img/quiz/quiz a.png" />
                </asp:TableCell>
                <asp:TableCell Width="80%" CssClass="lbl_3"><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" ImageUrl="~/img/quiz/quiz b.png"/>
                </asp:TableCell>
                <asp:TableCell CssClass="lbl_3"><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:ImageButton ID="ImageButton3" runat="server" OnClick="ImageButton3_Click" ImageUrl="~/img/quiz/quiz c.png" />
                </asp:TableCell>
                <asp:TableCell CssClass="lbl_3"><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
             <asp:TableCell ColumnSpan="2">
                <br/>
                <br/>
             </asp:TableCell>
         </asp:TableRow>
         <asp:TableRow>
            <asp:TableCell ColumnSpan="2"><asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/img/next.png" OnClick="ImageButton5_Click" ImageAlign="Right" />&nbsp;<asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/img/prev.png" OnClick="ImageButton6_Click" ImageAlign="Right" />&nbsp;</asp:TableCell>
         </asp:TableRow>            
        </asp:Table>

    <%--2. <asp:Label ID="Label1" CssClass="lbl_2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="A" Height="55px" Width="66px" />
&nbsp;<asp:Label ID="Label2" CssClass="lbl_1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" Text="B" OnClick="Button2_Click" Height="55px" Width="66px" />
&nbsp;<asp:Label ID="Label3" CssClass="lbl_1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button3" runat="server" Text="C" OnClick="Button3_Click" Height="55px" Width="66px" />
&nbsp;<asp:Label ID="Label4" CssClass="lbl_1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button4" runat="server" Text="D" OnClick="Button4_Click" Height="55px" Width="66px" />
&nbsp;<asp:Label ID="Label5" CssClass="lbl_1" runat="server" Text="Label"></asp:Label>

    <br />
        <br />
        <asp:ImageButton ID="ImageButton1" OnClick="Button5_Click" runat="server" ImageUrl="/img/back.png" />&nbsp;
        <asp:ImageButton ID="ImageButton2" OnClick="Button6_Click" runat="server" ImageUrl="/img/next.png"/>--%>
    </div>
</asp:Content>
