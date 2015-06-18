<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="EditarPerfil.aspx.cs" Inherits="Cliente_EditarPerfil" %>
<%@ PreviousPageType VirtualPath="~/Inicio/LoginC.aspx" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" style="width: 42%; border: 1px solid #cccccc">
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700" Text="EDITAR PERFIL"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 26px">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la informacion que desea cambiar."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 26px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 2px">
                <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
                &nbsp;<asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label3" runat="server" Text="Direccion:"></asp:Label>
                &nbsp;<asp:Label ID="Label25" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtdireccion" runat="server" Height="21px" Width="310px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label10" runat="server" Text="Telefono:"></asp:Label>
                &nbsp;<asp:Label ID="Label24" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txttelefono" runat="server" Height="21px" Width="190px" MaxLength="8"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label12" runat="server" Text="No. Tarjeta de Credito:"></asp:Label>
                &nbsp;<asp:Label ID="Label21" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtcredito" runat="server" Height="21px" Width="190px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 13px">
            </td>
        </tr>
        <tr>
            <td class="right" bgcolor="White" style="text-align: left; width: 509px;">
                <asp:HyperLink ID="Atras" runat="server" NavigateUrl="Cotizacion.aspx">&lt;&lt; Atras</asp:HyperLink>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td>
            <td bgcolor="White">
                <asp:Button ID="Guardar" runat="server" Text="GUARDAR CAMBIOS" Font-Size="Small" Height="37px" Width="145px" OnClick="Guardar_Click" />
            </td>
        </tr>
        <tr>
            <td class="right" bgcolor="White" colspan="2">
            &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <li>
        <br />
    </li>
    Usuario:
<asp:Label ID="Nombre" runat="server" style="text-align: right" Text="Label"></asp:Label>
</asp:Content>


