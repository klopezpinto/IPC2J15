<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterPage.master" AutoEventWireup="true" CodeFile="LoginC.aspx.cs" Inherits="Inicio_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 108%; border: 1px solid #cccccc; background-color: #CCCCCC" align="center">
        <tr>
            <td style="width: 1112px; height: 32px; border-left-style: none; border-left-color: #666666; border-right-color: #E8E8E8; border-right-width: 2px; border-top-color: #CCCCCC; border-bottom-color: #CCCCCC;">
            </td>
            <td rowspan="4">
                &nbsp;</td>
            <td rowspan="4" style="width: 220px">
                <asp:Image ID="Image1" runat="server" Height="205px" ImageUrl="~/Inicio/images/demo/usuario.jpg" Width="235px" />
            </td>
            <td style="width: 146px; height: 32px;"></td>
            <td style="height: 32px;" colspan="2">
                <asp:Label ID="Label3" runat="server" style="font-size: large" Text="¿YA ESTÁ REGISTRADO?"></asp:Label>
                <br />
                <asp:Label ID="Label4" runat="server" style="font-size: x-small" Text="Si usted tiene una cuenta con nosotros, por favor ingrese."></asp:Label>
                <br />
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
            <td style="width: 5px; height: 32px;"></td>
        </tr>
        <tr>
            <td style="width: 1112px; text-align: center; border-left-style: none; border-left-color: #666666; border-right-color: #E8E8E8; border-right-width: 2px; border-top-color: #CCCCCC; border-bottom-color: #CCCCCC;">
                <asp:Label ID="Label1" runat="server" style="font-size: large" Text="¿ES NUEVO AQUÍ?"></asp:Label>
                <br style="border-right: 2px solid #E8E8E8" />
                <asp:Label ID="Label2" runat="server" style="font-size: x-small" Text="¡Registrarse es gratis y sencillo!"></asp:Label>
            </td>
            <td style="width: 146px">&nbsp;</td>
            <td style="width: 424px; font-size: large; font-weight: 700; ">Usuario:<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                </td>
            <td style="width: 35px; font-size: small;">
                <asp:TextBox ID="txtuser" runat="server" Height="16px" Width="205px" Font-Size="Small" style="font-size: medium"></asp:TextBox>
            </td>
            <td style="width: 5px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 1112px; text-align: center; height: 24px; border-left-style: none; border-left-color: #666666; border-right-color: #E8E8E8; border-right-width: 2px; border-top-color: #CCCCCC; border-bottom-color: #CCCCCC;">
                <asp:Button ID="CuentaNueva" runat="server" Height="37px" Text="CREAR UNA CUENTA" Width="171px" OnClick="CuentaNueva_Click" />
            </td>
            <td style="width: 146px; height: 24px;"></td>
            <td style="width: 424px; font-size: large; font-weight: 700; height: 24px;">Contraseña: <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                </td>
            <td style="width: 35px; height: 24px; font-size: small;">
                <asp:TextBox ID="txtpass" runat="server" Height="16px" Width="205px" Font-Size="Small" TextMode="Password" style="font-size: medium"></asp:TextBox>
            </td>
            <td style="width: 5px; height: 24px;"></td>
        </tr>
        <tr>
            <td style="width: 1112px; border-left-style: none; border-left-color: #666666; border-right-color: #E8E8E8; border-right-width: 2px; border-top-color: #CCCCCC; border-bottom-color: #CCCCCC;">
                &nbsp;</td>
            <td style="width: 146px">&nbsp;</td>
            <td style="width: 424px">&nbsp;</td>
            <td align="center" style="width: 35px; text-align: center">
                <asp:Button ID="Ingresar" runat="server" Height="37px" Text="INGRESAR" Width="123px" OnClick="Ingresar_Click" />
            </td>
            <td style="width: 5px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

