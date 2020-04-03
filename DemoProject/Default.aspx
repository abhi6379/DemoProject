<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" ID="lbl_try"></asp:Label>
        <asp:Label runat="server" ID="lbl_catch"></asp:Label>
        <asp:Label runat="server" ID="lbl_finally"></asp:Label><br />
        <asp:TextBox runat="server" ID="txt_val" ></asp:TextBox>
        <asp:Button runat="server" ID="btn_save" OnClick="btn_save_Click" Text="Save"/><br />
        <asp:Label runat="server" ID="lbl_stringReverse"></asp:Label>
    </form>
</body>
</html>
dsfsfs