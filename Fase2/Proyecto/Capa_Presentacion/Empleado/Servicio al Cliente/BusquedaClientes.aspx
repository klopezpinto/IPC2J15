<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Servicio al Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="BusquedaClientes.aspx.cs" Inherits="Empleado_Servicio_al_Cliente_BusquedaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 800px;">
        <table style="width: 100%; border: 1px solid #cccccc">
            <tr>
                <td colspan="3" style="height: 26px">
                    <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700; text-align: center;" Text="BUSQUEDA DE CLIENTES"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 304px">
                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
                    <asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="280px"></asp:TextBox>
                </td>
                <td style="width: 296px">
                    <asp:Label ID="Label31" runat="server" Text="Apellido:"></asp:Label>
                    <asp:Label ID="Label32" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="280px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Buscar" runat="server" Text="BUSCAR" Font-Size="Small" Height="37px" Width="82px" OnClick="Buscar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 26px"></td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label33" runat="server" Text="No. Casilla:" style="font-size: large"></asp:Label>
&nbsp;<asp:Label ID="casilla" runat="server" style="font-weight: 700; font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

