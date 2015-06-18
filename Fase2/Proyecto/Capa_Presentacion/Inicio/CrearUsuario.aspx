<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterPage.master" AutoEventWireup="true" CodeFile="CrearUsuario.aspx.cs" Inherits="Inicio_CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center" style="width: 42%; border: 1px solid #cccccc">
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700" Text="CREAR UNA CUENTA"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 26px">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para crear su cuenta."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 26px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 2px">
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
                <asp:Label ID="Label14" runat="server" Text="DPI:"></asp:Label>
                &nbsp;<asp:Label ID="Label23" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtdpi" runat="server" Height="21px" Width="190px" MaxLength="9"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label11" runat="server" Text="NIT:"></asp:Label>
                <br />
                <asp:TextBox ID="txtnit" runat="server" Height="21px" Width="190px" MaxLength="9"></asp:TextBox>
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
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label15" runat="server" Text="Nombre de Usuario:"></asp:Label>
                &nbsp;<asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtusuario" runat="server" Height="21px" Width="190px" MaxLength="15"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label16" runat="server" Text="Contraseña:"></asp:Label>
                &nbsp;<asp:Label ID="Label19" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtcontraseña1" runat="server" Height="21px" Width="190px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White">
                <asp:Label ID="Label17" runat="server" Text="Confirmar Contraseña:"></asp:Label>
                &nbsp;<asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtcontraseña2" runat="server" Height="21px" Width="190px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" bgcolor="White" style="height: 13px">
            </td>
        </tr>
        <tr>
            <td class="right" bgcolor="White" style="text-align: left; width: 509px;">
                <asp:HyperLink ID="Atras" runat="server" NavigateUrl="LoginC.aspx">&lt;&lt; Atras</asp:HyperLink>
            </td>
            <td bgcolor="White">
                <asp:Button ID="Registrarse" runat="server" Text="Registrarse" Font-Size="Small" Height="37px" Width="95px" OnClick="Registrarse_Click" />
            </td>
        </tr>
        <tr>
            <td class="right" bgcolor="White" colspan="2">
            &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
    </table>
</asp:Content>

