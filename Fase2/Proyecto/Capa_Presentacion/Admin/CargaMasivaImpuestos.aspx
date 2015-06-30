<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="CargaMasivaImpuestos.aspx.cs" Inherits="Admin_CargaMasivaImpuestos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; " Text="CARGAR ARCHIVO CSV - IMPUESTOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label31" runat="server" style="text-align: left; font-weight: 700" Text="Agregar Impuestos:"></asp:Label>
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
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

