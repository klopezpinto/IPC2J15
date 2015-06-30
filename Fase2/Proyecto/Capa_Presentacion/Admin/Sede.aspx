<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="Sede.aspx.cs" Inherits="Admin_Sede" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td>
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="SEDE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para crear una nueva sede."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small; text-align: left;" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label31" runat="server" style="text-align: left; " Text="Codigo de Sede:"></asp:Label>
                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtcodsede" runat="server" Width="216px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label32" runat="server" style="text-align: left; " Text="Pais:"></asp:Label>
                <asp:Label ID="Label36" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:TextBox ID="txtpais" runat="server" Width="294px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
                <asp:Button ID="Crear" runat="server" Text="Crear" Font-Size="Small" Height="37px" Width="95px" OnClick="Crear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

