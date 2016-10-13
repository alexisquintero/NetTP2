<%@ Page Title="Especialidades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripción:"></asp:Label>
        <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
    </asp:Panel>
    <asp:Panel ID="gridActiconsPanel" runat="server">
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
