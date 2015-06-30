<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="DespedirEmpleados.aspx.cs" Inherits="Empleado_Director_DespedirEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 346px; border: 1px solid #cccccc" align="center">
    <tr>
        <td style="height: 26px; width: 322px" colspan="2">
            <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="ELIMINAR EMPLEADO" OnInit="Label30_Init"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 322px" colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Codigo de Usuario:"></asp:Label>
            <asp:TextBox ID="txtcodigo" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 322px" colspan="2">
            <asp:Label ID="Label32" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 322px" colspan="2">
            <asp:Label ID="Label33" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 2064px; text-align: right;">
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Director/EquipoEliminar.aspx">&lt;&lt; Atras</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        <td style="width: auto; text-align: center;">
                <asp:Button ID="Eliminar" runat="server" Text="Eliminar" Font-Size="Small" Height="37px" Width="119px" OnClick="Guardar_Click" />
            </td>
    </tr>
</table>
</asp:Content>

