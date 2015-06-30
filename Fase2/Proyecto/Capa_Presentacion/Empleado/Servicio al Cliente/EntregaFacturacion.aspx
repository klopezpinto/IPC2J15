<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Servicio al Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="EntregaFacturacion.aspx.cs" Inherits="Empleado_Servicio_al_Cliente_EntregaFacturacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 800px;">
        <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700; text-align: center;" Text="PAQUETES POR CASILLA EN SUCURSAL"></asp:Label>
        <br />
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            <br />
        <br />
                <asp:Label ID="Label2" runat="server" Text="Casilla:"></asp:Label>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtcasiila" runat="server" Height="21px" Width="280px"></asp:TextBox>
            &nbsp;
                <asp:Button ID="Guardar" runat="server" Text="BUSCAR" Font-Size="Small" Height="37px" Width="82px" OnClick="Guardar_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="cod_paquete" EnableModelValidation="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:CommandField SelectImageUrl="~/Empleado/Director/images/demo/Select-icon.png" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Servicio al Cliente/EntregaFacturacion.aspx">&lt;&lt; Recargar &gt;&gt;</asp:HyperLink>
    </div>
</asp:Content>

