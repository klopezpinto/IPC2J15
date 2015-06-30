<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="ModificarContratacion.aspx.cs" Inherits="Empleado_Director_ModificarContratacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table style="width: 336px; border: 1px solid #cccccc" align="center">
    <tr>
        <td style="height: 26px; " colspan="2">
            <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="MODIFICAR CONTRATACION:" OnInit="Label30_Init"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 26px; " colspan="2">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Codigo de Usuario:"></asp:Label>
            <asp:TextBox ID="txtcodigo" runat="server" Height="21px" Width="240px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label32" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label33" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label35" runat="server" Text="Sueldo:"></asp:Label>
                <asp:Label ID="Label39" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
            <asp:TextBox ID="txtsueldo" runat="server" Height="21px" Width="305px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="Label36" runat="server" Text="Puesto:"></asp:Label>
                <asp:Label ID="Label40" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
            <asp:TextBox ID="txtpuesto" runat="server" Height="21px" Width="303px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 1536px">
            <asp:Label ID="Label37" runat="server" Text="Sucursal:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT [cod_sucursal] FROM [Sucursal]"></asp:SqlDataSource>
        </td>
        <td>
            <asp:Label ID="Label38" runat="server" Text="Departamento:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="cod_departamento" DataValueField="cod_departamento" Height="16px" Width="68px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT [cod_departamento] FROM [Departamento]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 1536px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Director/EquipoModificar.aspx">&lt;&lt; Atras</asp:HyperLink>
        </td>
        <td style="width: auto; text-align: right;">
                <asp:Button ID="Modificar" runat="server" Text="Guardar Cambios" Font-Size="Small" Height="37px" Width="180px" OnClick="Crear_Click" />
        </td>
    </tr>
</table>

</asp:Content>

