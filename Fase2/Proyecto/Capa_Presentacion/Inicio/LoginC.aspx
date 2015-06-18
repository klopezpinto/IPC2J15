<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterPage.master" AutoEventWireup="true" CodeFile="LoginC.aspx.cs" Inherits="Inicio_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 70%; border: 1px solid #cccccc; background-color: #CCCCCC" align="center">
        <tr>
            <td rowspan="4" style="width: 220px">
                <asp:Image ID="Image1" runat="server" Height="205px" ImageUrl="~/Inicio/images/demo/usuario.jpg" Width="235px" />
            </td>
            <td style="width: 13px">&nbsp;</td>
            <td style="width: 76px">&nbsp;</td>
            <td style="width: 35px">&nbsp;</td>
            <td style="width: 295px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 13px">&nbsp;</td>
            <td style="width: 76px; font-size: x-large; font-weight: 700; text-align: center;">Usuario:</td>
            <td style="width: 35px">
                <asp:TextBox ID="txtuser" runat="server" Height="36px" Width="205px" Font-Size="Large"></asp:TextBox>
            </td>
            <td style="width: 295px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 13px">&nbsp;</td>
            <td style="width: 76px; font-size: x-large; font-weight: 700; text-align: center;">Contraseña:</td>
            <td style="width: 35px">
                <asp:TextBox ID="txtpass" runat="server" Height="36px" Width="205px" Font-Size="Large" TextMode="Password"></asp:TextBox>
            </td>
            <td style="width: 295px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 13px">&nbsp;</td>
            <td style="width: 76px">&nbsp;</td>
            <td align="center" style="width: 35px; text-align: center">
                <asp:Button ID="Button1" runat="server" Height="37px" Text="Ingresar" Width="123px" OnClick="Button1_Click" />
            </td>
            <td style="width: 295px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

