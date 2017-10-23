<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_nonstaff_quizselect.aspx.cs" Inherits="DigitalFeedback_UCW.Module.NonStaff.UCW_nonstaff_quizselect" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell CssClass="lbl_2">Please Select the Pop-Quiz Set</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:ImageButton ID="Imgbtn1" runat="server" ImageUrl="~/img/quiz/quiz set 1.png" OnClick="Imgbtn1_Click"></asp:ImageButton>
                &nbsp;<asp:ImageButton ID="Imgbtn2" runat="server" ImageUrl="~/img/quiz/quiz set 2.png" OnClick="Imgbtn2_Click" />
                &nbsp;<asp:ImageButton ID="Imgbtn3" runat="server" ImageUrl="~/img/quiz/quiz set 3.png" OnClick ="Imgbtn3_Click" />
                &nbsp;<asp:ImageButton ID="Imgbtn4" runat="server" ImageUrl="~/img/quiz/quiz set 4.png" OnClick="Imgbtn4_Click" />
                &nbsp;<asp:ImageButton ID="Imgbtn5" runat="server" ImageUrl="~/img/quiz/quiz set 5.png" OnClick="Imgbtn5_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
