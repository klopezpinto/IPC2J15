<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Sucursal.aspx.cs" Inherits="Admin_Sucursal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="SUCURSAL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: left">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para crear una nueva sucursal."></asp:Label>
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
                <asp:Label ID="Label31" runat="server" style="text-align: left; " Text="Codigo de Sucursal:"></asp:Label>
                <asp:Label ID="Label38" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtcodsuc" runat="server" Width="215px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label32" runat="server" style="text-align: left; " Text="Dirección:"></asp:Label>
                <asp:Label ID="Label39" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtdireccion" runat="server" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label33" runat="server" style="text-align: left; " Text="Telefono:"></asp:Label>
                <asp:Label ID="Label40" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txttelefono" runat="server" Width="283px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 33px">
                <asp:Label ID="Label34" runat="server" style="text-align: left; " Text="Capacidad Max de Empleados:"></asp:Label>
                <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtempleados" runat="server" Width="146px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label35" runat="server" style="text-align: left; " Text="Comisión:"></asp:Label>
                <asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtcomision" runat="server" Width="81px"></asp:TextBox>
            &nbsp;
            </td>
            <td>
                <asp:Label ID="Label36" runat="server" style="text-align: left; " Text="Costo por Libra:"></asp:Label>
                <asp:Label ID="Label43" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtpeso" runat="server" Width="81px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;<asp:Label ID="Label37" runat="server" style="text-align: left; " Text="Codigo de Sede:"></asp:Label>
                <asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sede" DataValueField="cod_sede">
                </asp:DropDownList>
&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" ProviderName="<%$ ConnectionStrings:QuetzalExpressConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Sede]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 26px" colspan="2">
                <asp:Button ID="Crear" runat="server" Text="Crear" Font-Size="Small" Height="37px" Width="95px" OnClick="Crear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

