<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DB_Upload.aspx.cs" Inherits="DigitalFeedback_UCW.Module.Other.DB_Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="MLNG" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="SKG" />
        <asp:Button ID="Button3" runat="server" Text="COM" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="EXT" OnClick="Button4_Click" />
        &nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="All" />
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="CLEAR" />
        <br />
        <br />
        mlng :
        <asp:Label ID="lblmlng" runat="server" Text="Label"></asp:Label>
        <br />
        skg : <asp:Label ID="lblskg" runat="server" Text="Label"></asp:Label>
        <br />
        com : <asp:Label ID="lblcom" runat="server" Text="Label"></asp:Label>
        <br />
        ext : <asp:Label ID="lblext" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        all : <asp:Label ID="lblall" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
