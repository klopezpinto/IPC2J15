<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Importaciones GUA/MasterPage.master" AutoEventWireup="true" CodeFile="EstadosPaquetes.aspx.cs" Inherits="Empleado_Importaciones_EstadosPaquetes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 250px;">
        <table style="width: auto; border: 1px solid #cccccc; margin-right: 0px;" align="center">
            <tr>
                <td>
                    <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="ESTADO DE PAQUETES"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 1px">
                    <asp:Label ID="Label28" runat="server" Style="font-size: x-small" Text="Seleccione el lote que desee recibir."></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: auto; text-align: center; font-size: 13px;">
                    <asp:Label ID="Label45" runat="server" Text="Codigo de Lote:"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource3" DataTextField="cod_lote" DataValueField="cod_lote" Font-Size="Small">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Lote]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="height: 3px; text-align: center; font-size: 13px;">
                </td>
            </tr>
            <tr>
                <td class="right" style="text-align: center;">
                    <asp:Button ID="Contratar0" runat="server" Text="Recibir Lote" Font-Size="Small" Height="37px" Width="95px" OnClick="Contratar0_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

