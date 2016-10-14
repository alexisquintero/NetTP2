<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                <asp:BoundField DataField="IDComision" HeaderText="ID Comision" />
                <asp:BoundField DataField="IDMateria" HeaderText="ID Materia" />
                <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripción:"></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="anioCalendarioLabel" runat="server" Text="Año calendario:"></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="cupoLabel" runat="server" Text="Cupo:"></asp:Label>
        <asp:TextBox ID="cupoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="idComisionLabel" runat="server" Text="ID Comision:"></asp:Label>
        <asp:TextBox ID="idComisionTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="idMateriaLabel" runat="server" Text="ID Materia:"></asp:Label>
        <asp:TextBox ID="idMateriaTextBox" runat="server"></asp:TextBox>
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
