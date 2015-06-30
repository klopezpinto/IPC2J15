<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Departamento.aspx.cs" Inherits="Admin_Departamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="DEPARTAMENTO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para crear un nuevo departamento."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: left">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small; text-align: left;" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: left">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label31" runat="server" style="text-align: left; " Text="Codigo de Departamento:"></asp:Label>
                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtcoddep" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label32" runat="server" style="text-align: left; " Text="Nombre:"></asp:Label>
                <asp:Label ID="Label38" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="tipo" runat="server" Height="16px" Width="296px">
                    <asp:ListItem>Bodega</asp:ListItem>
                    <asp:ListItem>Importaciones</asp:ListItem>
                    <asp:ListItem>Servicio al Cliente</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label33" runat="server" style="text-align: left; " Text="Director:"></asp:Label>
                <asp:Label ID="Label39" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="director" runat="server" DataSourceID="SqlDataSource2" DataTextField="cod_empleado" DataValueField="cod_empleado" Height="16px" Width="140px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Empleado]"></asp:SqlDataSource>
            </td>
            <td>
                <asp:Label ID="Label37" runat="server" style="text-align: left; " Text="Codigo de Sucursal:"></asp:Label>
                <asp:Label ID="Label40" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="suc" runat="server" DataSourceID="CodSucursal" DataTextField="cod_sucursal" DataValueField="cod_sucursal">
                </asp:DropDownList>
                <asp:SqlDataSource ID="CodSucursal" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Sucursal]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px" colspan="2">
                <asp:Button ID="Crear" runat="server" Text="Crear" Font-Size="Small" Height="37px" Width="95px" OnClick="Crear_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>

