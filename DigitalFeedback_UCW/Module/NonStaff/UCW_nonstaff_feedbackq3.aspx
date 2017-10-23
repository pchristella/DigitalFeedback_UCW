<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_nonstaff_feedbackq3.aspx.cs" Inherits="DigitalFeedback_UCW.Module.NonStaff.UCW_nonstaff_feedbackq3" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <br />
       <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="10" CssClass="lbl_2">3. How would you rate the <font color="red">exhibitions/booths</font> presentations?</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="10" CssClass="lbl_3">Bagaimanakah penilaian anda terhadap <font color="red">pameran</font> yang disediakan?</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="10"></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <br />
                <br />  
                <br />           
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="10">
                <asp:Table runat="server" Width="100%">
                    <asp:TableRow>
                        <asp:TableCell Width="40%"><asp:Image ID="Image1" runat="server" ImageUrl="~/img/feedback/fb_lvl1.png" ImageAlign="Left" /></asp:TableCell>
                        <asp:TableCell Width="20%"><asp:Image ID="Image2" runat="server" ImageUrl="~/img/feedback/fb_lvl2.png" /></asp:TableCell>
                        <asp:TableCell Width="40%"><asp:Image ID="Image3" runat="server" ImageUrl="~/img/feedback/fb_lvl3.png" ImageAlign="Right" /></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell><asp:ImageButton ID="btn1" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_1b.png" OnClick="btn1_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn2" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_2b.png" OnClick="btn2_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn3" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_3b.png" OnClick="btn3_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn4" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_4b.png" OnClick="btn4_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn5" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_5b.png" OnClick="btn5_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn6" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_6b.png" OnClick="btn6_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn7" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_7b.png" OnClick="btn7_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn8" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_8b.png" OnClick="btn8_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn9" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_9b.png" OnClick="btn9_Click"></asp:ImageButton></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="btn10" runat="server" ImageUrl="~/img/feedback/fb_btn_set2_10b.png" OnClick="btn10_Click"></asp:ImageButton></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    </div>
</asp:Content>
