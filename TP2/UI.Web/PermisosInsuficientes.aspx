<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PermisosInsuficientes.aspx.cs" Inherits="UI.Web.PermisosInsuficientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblPermisos" runat="server" Text="Permisos insuficientes"></asp:Label>
    
        <br />
        <asp:Label ID="lblMenu" runat="server" Text="Volviendo al menu en 5 segundos"></asp:Label>
        <br />
        <asp:Label ID="lblO" runat="server" Text="o"></asp:Label>
    
    </div>
        <asp:LinkButton ID="lbMenu" runat="server" PostBackUrl="&quot;">Volver al menu</asp:LinkButton>
    </form>
</body>
</html>
