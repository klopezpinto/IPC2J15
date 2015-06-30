<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="PaqueteIndividual.aspx.cs" Inherits="Cliente_PaqueteIndividual" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label33" runat="server" Style="text-align: right" Text="Usuario:"></asp:Label>
    &nbsp;<asp:Label ID="Label32" runat="server" Style="text-align: right" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="INFORMACION DE PAQUETE" OnInit="Label30_Init"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Codigo de Paquete:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtcodpaq" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                <asp:Label ID="Label2" runat="server" Text="Libras:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtlibras" runat="server" Height="21px" Width="143px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Precio en $:"></asp:Label>
                <br />
                <asp:TextBox ID="txtprecio" runat="server" Height="21px" Width="143px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;<asp:Label ID="Label34" runat="server" Text="Estado:"></asp:Label>
                <br />
                <asp:TextBox ID="txtestado" runat="server" Height="21px" Width="310px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label10" runat="server" Text="Categoria:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtcategoria" runat="server" Height="21px" Width="309px" MaxLength="8" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label12" runat="server" Text="Monto Total:"></asp:Label>
                &nbsp;<br />
                <asp:TextBox ID="txtmonto" runat="server" Height="21px" Width="190px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 13px"></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Cliente/ConsultaPaquetes.aspx">&lt;&lt; Atras</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

