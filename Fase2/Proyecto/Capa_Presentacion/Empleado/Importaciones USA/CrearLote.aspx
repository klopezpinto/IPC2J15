<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Importaciones USA/MasterPage.master" AutoEventWireup="true" CodeFile="CrearLote.aspx.cs" Inherits="Empleado_Importaciones_CrearLote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 500px;">
        <table style="width: auto; border: 1px solid #cccccc; margin-right: 0px;" align="center">
            <tr>
                <td>
                    <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="CREAR LOTE"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label28" runat="server" Style="font-size: small" Text="Introduzca la siguiente información para crear un nuevo lote."></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 26px; text-align: center; ">
                    <asp:Label ID="Label45" runat="server" Text="Codigo de Lote:"></asp:Label>
                    &nbsp;<asp:Label ID="Label46" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txtlote" runat="server"></asp:TextBox>
                    <br />
                    <br />
                <asp:Label ID="Label32" runat="server" Text="Lotes ya Existentes:" style="font-size: x-small"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_lote" DataValueField="cod_lote">
                </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Lote]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="right" style="text-align: center;">
                    <asp:Button ID="Contratar" runat="server" Text="Añadir" Font-Size="Small" Height="37px" Width="95px" OnClick="Contratar_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

