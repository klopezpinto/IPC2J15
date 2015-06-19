<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="Cotizacion.aspx.cs" Inherits="Cliente_Pedidos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc; text-align: left;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Precio en U.S. $:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="190px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Shipping en U.S. $:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="190px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Peso en Lbs.:"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Height="21px" Width="190px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label4" runat="server" Text="Tipo:"></asp:Label>
                <br />
                <asp:DropDownList ID="Tipo" runat="server" Height="18px">
                    <asp:ListItem>Consola de Videojuegos - 15%</asp:ListItem>
                    <asp:ListItem>Celulares - 0%</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2"><span style="color: rgb(102, 102, 102); font-family: ABeeZee; font-size: 10px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 11px; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none; background-color: rgb(252, 252, 252);">Incluye DAI(arancel), 12% IVA, Seguro, Fletes, Tramites Aduanales. Entrega a domicilio Gratis en el Area Metropolitana. *</span></td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                <asp:Label ID="Label5" runat="server" Text="Valor de Merc. :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblmerc" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                <asp:Label ID="Label6" runat="server" Text="Shipping en U.S. :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblshipping" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                <asp:Label ID="Label7" runat="server" Text="Servicio Quetzal Express:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblservicio" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                <asp:Label ID="Label8" runat="server" Text="Impuestos:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblimpuestos" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                <asp:Label ID="Label9" runat="server" Text="Total :"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lbltotal" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: right; width: 349px;">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="right" colspan="2">
                <asp:Button ID="Cotizar" runat="server" Text="Cotizar" Font-Size="Small" Height="37px" Width="95px" OnClick="Cotizar_Click" />
                &nbsp;
                <asp:Button ID="Pedir" runat="server" Text="Realizar Pedido" Font-Size="Small" Height="37px" Width="131px" />
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <asp:Label ID="Label33" runat="server" Style="text-align: right" Text="Usuario:"></asp:Label>
    &nbsp;<asp:Label ID="Label32" runat="server" Style="text-align: right" Text="Label"></asp:Label>
</asp:Content>


