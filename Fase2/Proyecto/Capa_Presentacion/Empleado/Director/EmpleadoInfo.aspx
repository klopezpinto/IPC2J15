<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="EmpleadoInfo.aspx.cs" Inherits="Empleado_Director_EmpleadoInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td style="height: 26px; width: 322px">
                <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="PERFIL DE EMPLEADO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label1" runat="server" Text="Codigo de Usuario:"></asp:Label>
                <asp:TextBox ID="txtcodigo" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label31" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtcontraseña" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label32" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label33" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label34" runat="server" Text="Direccion:"></asp:Label>
                <asp:TextBox ID="txtdireccion" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:Label ID="Label35" runat="server" Text="Telefono:"></asp:Label>
                <asp:TextBox ID="txttelefono" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 322px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 322px">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Director/Equipo.aspx">&lt;&lt; Atras</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

