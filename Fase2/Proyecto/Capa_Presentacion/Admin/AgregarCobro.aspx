<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="AgregarCobro.aspx.cs" Inherits="Admin_AgregarCobro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td colspan="2" style="height: 26px; text-align: center;">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="IMPUESTO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para agregar un nuevo impuesto."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 339px; text-align: left;">
                <asp:Label ID="Label31" runat="server" style="text-align: left; " Text="Categoria:"></asp:Label>
                <asp:Label ID="Label41" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
            &nbsp;<asp:TextBox ID="txtcategoria" runat="server" Width="216px"></asp:TextBox>
            </td>
            <td style="text-align: left">
                <asp:Label ID="Label32" runat="server" style="text-align: left; " Text="Porcentaje:"></asp:Label>
                <asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
            &nbsp;<asp:TextBox ID="txtporcentaje" runat="server" Width="202px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;" colspan="2">
                <asp:Button ID="Subir" runat="server" Text="Agregar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align: center;" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label33" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="PESOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label47" runat="server" style="font-size: small" Text="Introduzca la siguiente información para agregar un nuevo monto por peso."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Label ID="Label39" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 339px; text-align: left; height: 33px;">
                <asp:Label ID="Label34" runat="server" style="text-align: left; " Text="Sucursal:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal" Height="16px" Width="231px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Sucursal]"></asp:SqlDataSource>
            </td>
            <td style="text-align: left; height: 33px">
                <asp:Label ID="Label35" runat="server" style="text-align: left; " Text="Peso:"></asp:Label>
                <asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;<asp:TextBox ID="txtpeso" runat="server" Width="244px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 33px; text-align: center;" colspan="2">
                <asp:Button ID="Subir0" runat="server" Text="Agregar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir0_Click" />
            </td>
        </tr>
        <tr>
            <td style="height: 33px; text-align: center;" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: center; height: 32px;" colspan="2">
                <asp:Label ID="Label36" runat="server" style="font-size: large; font-weight: 700; " Text="COMISION"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center; " colspan="2">
                <asp:Label ID="Label48" runat="server" style="font-size: small" Text="Introduzca la siguiente información para agregar un nueva comision por sucursal."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;" colspan="2">
                <asp:Label ID="Label40" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 339px; text-align: left;">
                <asp:Label ID="Label37" runat="server" style="text-align: left; " Text="Sucursal:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal" Height="19px" Width="226px">
                </asp:DropDownList>
            </td>
            <td style="text-align: left">
                <asp:Label ID="Label38" runat="server" style="text-align: left; " Text="Comision:"></asp:Label>
                <asp:Label ID="Label46" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;<asp:TextBox ID="txtcomision" runat="server" Width="217px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;" colspan="2">
                <asp:Button ID="Subir1" runat="server" Text="Agregar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

