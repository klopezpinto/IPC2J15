<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="InfoDirector.aspx.cs" Inherits="Empleado_Director_InfoDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700" Text="PERFIL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px">
                <asp:Label ID="Label28" runat="server" Style="font-size: small" Text="Introduzca la informacion que desea cambiar."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Codigo de Usuario:" OnInit="Label1_Init"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtcodigo" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtcontraseña" runat="server" Height="21px" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label31" runat="server" Text="Apellido:"></asp:Label>
                <br />
                <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label32" runat="server" Text="Direccion:"></asp:Label>
                &nbsp;<asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtdireccion" runat="server" Height="21px" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label10" runat="server" Text="Telefono:"></asp:Label>
                &nbsp;<asp:Label ID="Label36" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txttelefono" runat="server" Height="21px" Width="190px" MaxLength="8"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label12" runat="server" Text="Departamento:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtdepartamento" runat="server" Height="21px" Width="190px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label33" runat="server" Text="Sucursal:"></asp:Label>
                <br />
                <asp:TextBox ID="txtsucursal" runat="server" Height="21px" Width="190px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label34" runat="server" Text="Pais Sede:"></asp:Label>
                <br />
                <asp:TextBox ID="txtpais" runat="server" Height="21px" Width="190px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 13px"></td>
        </tr>
        <tr>
            <td style="width: 188px;">&nbsp;</td>
            <td>
                <asp:Button ID="Guardar" runat="server" Text="GUARDAR CAMBIOS" Font-Size="Small" Height="37px" Width="145px" OnClick="Guardar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

