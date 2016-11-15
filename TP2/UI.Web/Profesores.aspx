<%@ Page Title="Profesores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="UI.Web.Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" />
                <asp:BoundField DataField="IDPlan" HeaderText="ID Plan" />
                <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar"/>
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido:"></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="apellidoTextBox" Display="Dynamic" ErrorMessage="El apellido no puede estar en blanco">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="nombreTextBox" Display="Dynamic" ErrorMessage="El nombre no puede estar en blanco">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion:"></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvDirecion" runat="server" ControlToValidate="direccionTextBox" Display="Dynamic" ErrorMessage="La dirección no puede estar en blanco">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="El email no puede estar en blanco">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Formato de EMail incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Formato incorrecto</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono:"></asp:Label>
        <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="telefonoTextBox" Display="Dynamic" ErrorMessage="El telefono no puede estar en blanco">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="fechaNacimientoLabel" runat="server" Text="Fecha de nacimiento:"></asp:Label>
        <asp:Calendar ID="fechaNacimientoCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan:"></asp:Label>
        <asp:TextBox ID="idPlanTextBox" runat="server"></asp:TextBox>       
    </asp:Panel>

    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click" >Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click" >Nuevo</asp:LinkButton>
    </asp:Panel>

    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click" >Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click" >Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
