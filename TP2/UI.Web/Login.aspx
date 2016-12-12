<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido al sistema"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
