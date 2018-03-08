<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Upi.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        INGRESO DE USUARIOS<br />
        <br />
        USUARIO:
        <asp:TextBox ID="idTextUsuario" runat="server"></asp:TextBox>
        <br />
        <br />
        CLAVE:
        <asp:TextBox ID="idTextClave" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="idLabelUsuarioExiste" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="idBotonLogin" runat="server" OnClick="idBotonLogin_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>
