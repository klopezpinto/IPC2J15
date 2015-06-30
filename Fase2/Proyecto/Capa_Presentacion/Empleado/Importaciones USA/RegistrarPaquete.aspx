<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Importaciones USA/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrarPaquete.aspx.cs" Inherits="Empleado_Importaciones_RegistrarPaquete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 341px; border: 1px solid #cccccc" align="center">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="REGISTRO DE PAQUETE"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 26px">
                <asp:Label ID="Label28" runat="server" Style="font-size: small" Text="Introduzca la siguiente información para registrar el nuevo paquete."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 26px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 2px">
                <asp:Label ID="Label31" runat="server" Text="Codigo de Paquete:"></asp:Label>
                <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtcodpaquete" runat="server" Height="20px" Width="308px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 2px" class="center">&nbsp;
                <asp:Label ID="Label32" runat="server" Text="Paquetes ya Existentes:" Style="font-size: x-small"></asp:Label>
                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_paquete" DataValueField="cod_paquete">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT [cod_paquete] FROM [Paquete]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="height: 2px; text-align: left; width: 2176px;" class="center">
                <asp:Label ID="Label34" runat="server" Text="Peso:"></asp:Label>
                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtpeso" runat="server" Height="18px" Width="141px"></asp:TextBox>
            </td>
            <td style="height: 2px; text-align: left;" class="center">
                <asp:Label ID="Label41" runat="server" Text="Precio en $:"></asp:Label>
                &nbsp;<asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtprecio" runat="server" Height="18px" Width="141px"></asp:TextBox>
            </td>
            <td style="height: 2px; text-align: left;" class="center">
                <asp:Label ID="Label43" runat="server" Text="Casilla:"></asp:Label>
                <asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <asp:TextBox ID="txtcasilla" runat="server" Height="18px" Width="141px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" Text="Categoria:"></asp:Label>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="categoria" DataValueField="categoria" Height="16px" Width="373px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Impuesto]"></asp:SqlDataSource>
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 13px"></td>
        </tr>
        <tr>
            <td class="right" style="text-align: right;" colspan="3">
                <asp:Button ID="Contratar" runat="server" Text="Registrar" Font-Size="Small" Height="37px" Width="95px" OnClick="Contratar_Click" />
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: left;" colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="right" style="text-align: left;" colspan="3">
                <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="Label37" runat="server" Style="font-size: large; font-weight: 700;" Text="CARGAR ARCHIVO CSV - PAQUETES"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 420px">
                            <asp:Label ID="Label39" runat="server" Style="text-align: left; font-weight: 700" Text="Agregar Paquetes:"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 420px">
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="360px" />
                        </td>
                        <td>
                            <asp:Button ID="Subir" runat="server" Text="CARGAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

