<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterPage.master" AutoEventWireup="true" CodeFile="LoginE.aspx.cs" Inherits="Inicio_LoginE" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 64%; border: 1px solid #cccccc; background-color: #CCCCCC" align="center">
        <tr>
            <td rowspan="3" style="width: 118px">
                <asp:Image ID="Image1" runat="server" Height="164px" ImageUrl="~/Inicio/images/demo/empleado.jpg" Width="217px" />
            </td>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" style="font-size: large" Text="¿ERES PARTE DE NUESTRO EQUIPO?"></asp:Label>
                <br />
                <asp:Label ID="Label4" runat="server" style="font-size: x-small" Text="Si usted es parte de nuestro equipo, por favor ingrese."></asp:Label>
                <br />
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 112px; font-size: large; font-weight: 700; height: 30px;">
                Usuario: <asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                </td>
            <td style="width: 35px; height: 30px; font-size: large;">
                <asp:TextBox ID="txtuser" runat="server" Height="16px" Width="205px" Font-Size="Large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 112px; font-size: x-large; font-weight: 700; ">
                </td>
            <td style="width: 35px; font-size: x-large; font-weight: 700; ">
                <asp:Button ID="Ingresar" runat="server" Height="37px" Text="INGRESAR" Width="123px" OnClick="Ingresar_Click" />
            </td>
        </tr>
        </table>
</asp:Content>

