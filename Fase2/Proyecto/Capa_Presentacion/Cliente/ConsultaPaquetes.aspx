<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultaPaquetes.aspx.cs" Inherits="Cliente_ConsultaPaquetes
    " %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 800px;">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="dpi" DataSourceID="SqlDataSource1" EnableModelValidation="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:CommandField ButtonType="Image" SelectImageUrl="~/Cliente/images/demo/Select-icon.png" SelectText="" ShowSelectButton="True" />
                <asp:BoundField DataField="dpi" HeaderText="dpi" ReadOnly="True" SortExpression="dpi" />
                <asp:BoundField DataField="usuario" HeaderText="usuario" SortExpression="usuario" />
                <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
                <asp:BoundField DataField="nit" HeaderText="nit" SortExpression="nit" />
                <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
                <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
                <asp:BoundField DataField="tarjeta_credito" HeaderText="tarjeta_credito" SortExpression="tarjeta_credito" />
                <asp:BoundField DataField="Sucursal_cod_sucursal" HeaderText="Sucursal_cod_sucursal" SortExpression="Sucursal_cod_sucursal" />
            </Columns>
            <HeaderStyle BackColor="White" ForeColor="#669900" />
        </asp:GridView>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <asp:Label ID="Label33" runat="server" Style="text-align: right" Text="Usuario:"></asp:Label>
    &nbsp;<asp:Label ID="Label32" runat="server" Style="text-align: right" Text="Label"></asp:Label>
</asp:Content>


