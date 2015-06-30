<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="CargaMasivaEmpleados.aspx.cs" Inherits="Admin_CargaMasivaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; " Text="CARGAR ARCHIVO CSV - EMPLEADOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label33" runat="server" Text="Para cargar un nuevo empleado, debes de cargar primero sus datos de usuario y luego ingresar los datos de empleado."></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label31" runat="server" style="text-align: left; font-weight: 700" Text="Agregar Usuario:"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="360px" />
            </td>
            <td>
                <asp:Button ID="Subir" runat="server" Text="CARGAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label32" runat="server" style="text-align: left; font-weight: 700" Text="Agregar Empleado:"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:FileUpload ID="FileUpload2" runat="server" Width="360px" />
            </td>
            <td>
                <asp:Button ID="Cargar" runat="server" Text="CARGAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Cargar_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

