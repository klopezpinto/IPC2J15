<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="EliminarCobro.aspx.cs" Inherits="Admin_EliminarCobro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td style="text-align: center;">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="IMPUESTO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left;">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para eliminar un impuesto."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left;">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small; text-align: left;" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Label ID="Label31" runat="server" style="text-align: left; " Text="Categoria:"></asp:Label>
                <asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource2" DataTextField="categoria" DataValueField="categoria" Height="16px" Width="196px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT [categoria] FROM [Impuesto]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;">
                <asp:Button ID="Subir" runat="server" Text="Eliminar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir_Click" />
            </td>
        </tr>
        <tr>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Label ID="Label33" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="PESOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label38" runat="server" style="font-size: small" Text="Introduzca la siguiente información para eliminar el monto por peso."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label40" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small; text-align: left;" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;">
                <asp:Label ID="Label34" runat="server" style="text-align: left; " Text="Sucursal:"></asp:Label>
                <asp:Label ID="Label43" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal" Height="16px" Width="214px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Sucursal]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="height: 33px; text-align: center;">
                <asp:Button ID="Subir0" runat="server" Text="Eliminar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir0_Click" />
            </td>
        </tr>
        <tr>
            <td style="height: 33px; ">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Label ID="Label36" runat="server" style="font-size: large; font-weight: 700; " Text="COMISION"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label39" runat="server" style="font-size: small" Text="Introduzca la siguiente información para eliminar el monto de comision."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label41" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small; text-align: left;" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">
                <asp:Label ID="Label37" runat="server" style="text-align: left; " Text="Sucursal:"></asp:Label>
                <asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_sucursal" DataValueField="cod_sucursal" Height="16px" Width="214px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align: center;">
                <asp:Button ID="Subir1" runat="server" Text="Eliminar" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

