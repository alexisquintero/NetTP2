<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="false" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged1">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                    <asp:BoundField HeaderText="Email" DataField="EMail" />
                    <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
                    <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:Panel>

        <asp:Panel ID="formPanel" Visible="False" runat="server">
            <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="nombreTextBox" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="nombreTextBox" Display="Dynamic" ErrorMessage="El nombre no puede estar en blanco">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="apellidoTextBox" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="apellidoTextBox" Display="Dynamic" ErrorMessage="El apellido no puede estar en blanco">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="EMail: "></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="El email no puede estar en blanco">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Formato de EMail incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Formato incorrecto</asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
            <asp:CheckBox ID="habilitadoCheckBox" runat="server" ></asp:CheckBox>
            <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="nombreUsuarioTextBox" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="nombreUsuarioTextBox" Display="Dynamic" ErrorMessage="El usuario no puede estar en blanco">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
            <asp:TextBox ID="claveTextBox" TextMode="Password" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="claveTextBox" Display="Dynamic" ErrorMessage="La clave no puede estar en blanco">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: "></asp:Label>
            <asp:TextBox ID="repetirClaveTextbox" TextMode="Password" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvRepetirClave" runat="server" ControlToValidate="repetirClaveTextbox" Display="Dynamic" ErrorMessage="Repetir clave no puede estar en blanco">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvEmail" runat="server" ControlToCompare="claveTextBox" ControlToValidate="repetirClaveTextbox" Display="Dynamic" ErrorMessage="Las claves no son iguales">Las claves no son iguales</asp:CompareValidator>
            <asp:ValidationSummary ID="vsUsuarios" runat="server" />
            <br />
        </asp:Panel>
     
        <asp:Panel ID="gridActionsPanel" runat="server">
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
            <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
            <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
        </asp:Panel>

        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
        </asp:Panel>

</asp:Content>
