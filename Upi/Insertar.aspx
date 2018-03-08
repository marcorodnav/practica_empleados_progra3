<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insertar.aspx.cs" Inherits="Upi.Insertar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        INGRESO DE EMPLEADOS<br />
        <br />
        ID_EMPLEADO:
        <asp:TextBox ID="IdTextIdEmpleado" runat="server"></asp:TextBox>
        <br />
        <br />
        NOMBRE: <asp:TextBox ID="idTextNombre" runat="server"></asp:TextBox>
        <br />
        <br />
        DIRECCION:
        <asp:TextBox ID="idTextDireccion" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="idBtnInsertar" runat="server" OnClick="idBtnInsertar_Click" Text="Insertar" />
        <br />
        <br />
        <asp:Label ID="idLabelExito" runat="server"></asp:Label>
        <br />
        <asp:HyperLink ID="idLinkRegresar" runat="server">Regresar</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
