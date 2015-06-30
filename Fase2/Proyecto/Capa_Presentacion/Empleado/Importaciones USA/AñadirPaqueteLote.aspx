<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Importaciones USA/MasterPage.master" AutoEventWireup="true" CodeFile="AñadirPaqueteLote.aspx.cs" Inherits="Empleado_Importaciones_AñadirPaqueteLote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 500px;">
        <table style="width: auto; border: 1px solid #cccccc; margin-right: 0px;" align="center">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="AÑADIR PAQUETE A LOTE"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                    <asp:Label ID="Label28" runat="server" Style="font-size: small" Text="Introduzca la siguiente información para añadir un apaquete a un lote."></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 26px">
                    <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 26px; text-align: center; width: 228px;">
                    <asp:Label ID="Label45" runat="server" Text="Codigo de Lote:"></asp:Label>
                    &nbsp;<asp:Label ID="Label46" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    &nbsp;
                <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource3" DataTextField="cod_lote" DataValueField="cod_lote">
                </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Lote]"></asp:SqlDataSource>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Importaciones/CrearLote.aspx">Crear Lote</asp:HyperLink>
                </td>
                <td style="height: 26px; width: 232px;">
                    <asp:Label ID="Label31" runat="server" Text="Codigo de Paquete:"></asp:Label>
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    &nbsp;<asp:DropDownList ID="DropDownList3" runat="server">
                    </asp:DropDownList>
                    <br />
                    <asp:Label ID="Label47" runat="server" Text="Codigo de Sucursal a Enviar:"></asp:Label>
                    <asp:Label ID="Label48" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    &nbsp;<asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal" Height="22px" Width="230px">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Sucursal]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Fecha:"></asp:Label>
                    &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    &nbsp;<asp:TextBox ID="txtfecha" runat="server" Width="387px"></asp:TextBox>
                    &nbsp;<br />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 13px"></td>
            </tr>
            <tr>
                <td class="right" style="text-align: center;" colspan="2">
                    <asp:Button ID="Contratar" runat="server" Text="Añadir" Font-Size="Small" Height="37px" Width="95px" OnClick="Contratar_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

