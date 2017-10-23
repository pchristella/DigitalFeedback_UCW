<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UCW_checkout_list.aspx.cs" Inherits="DigitalFeedback_UCW.Module.CheckOut.UCW_checkout_list" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        function updateItem(url) {
            str_msg = confirm("Confirm to checkout?");

            if (str_msg == true) {
                window.location.href = url;
            }
            else {
                return false;
            }
        }

        function windowOpen(url) {
            window.open(url,'_blank','location=yes,height=570,width=570,scrollbars=yes,status=yes');
        }
    </script>
    <div>
        
        <br />
        <br />
        
        <br />
        <br />
        <asp:Table runat="server" Width="100%">
            <asp:TableRow>
                <asp:TableCell Width="45%"><asp:TextBox ID="txt" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" /></asp:TableCell>
                <asp:TableCell Width="10%"></asp:TableCell>
                <asp:TableCell Width="45%"><asp:TextBox ID="txt_nonstaff" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell VerticalAlign="Top">
                    <asp:Table runat="server" Width="100%" ID="tbllist_staff" CssClass="lbl_4" >
                        <asp:TableRow>
                            <asp:TableCell Width="30%">Name</asp:TableCell>
                            <asp:TableCell Width="20%">Staff ID</asp:TableCell>
                            <asp:TableCell Width="20%">Quiz Score</asp:TableCell>
                            <asp:TableCell Width="30%">Action</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell VerticalAlign="Top">
                    <asp:Table runat="server" Width="100%" ID="tbllist_nonstaff" CssClass="lbl_4">
                        <asp:TableRow>
                            <asp:TableCell Width="30%">Name</asp:TableCell>
                            <asp:TableCell Width="20%">IC/Passport No.</asp:TableCell>
                            <asp:TableCell Width="20%">Quiz Score</asp:TableCell>
                            <asp:TableCell Width="30%">Action</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        
        <br/>
        <br />
        <asp:Button align="right" ID="Button2" runat="server" Text="Main" OnClick="Button2_Click" />
    </div>
</asp:Content>
