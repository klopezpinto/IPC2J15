<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Bodega/MasterPage.master" AutoEventWireup="true" CodeFile="PaquetePerdido.aspx.cs" Inherits="Empleado_Bodega_PaquetePerdido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: auto; border: 1px solid #cccccc" align="center">
        <tr>
            <td>
                <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="CONSULTA DE PAQUETES"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
                <asp:Label ID="Label28" runat="server" Style="font-size: small" Text="Introduzca la siguiente información para encontrar paquetes perdidos."></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" Style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">
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
                            <asp:Label ID="Label39" runat="server" Style="text-align: left; font-weight: 700" Text="Consultar Paquetes:"></asp:Label>
&nbsp;<asp:Label ID="Label46" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                        </td>
                        <td rowspan="2" style="width: auto; height: auto">
                            <asp:Button ID="Subir" runat="server" Text="CARGAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 420px">
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="360px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 420px">
                            <asp:Label ID="Label45" runat="server" Style="text-align: left; font-weight: 700" Text="Consultar Paquetes:"></asp:Label>
&nbsp;<asp:Label ID="Label47" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;&nbsp;
                            <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="cod_lote" DataValueField="cod_lote">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Lote]"></asp:SqlDataSource>
                        </td>
                        <td style="width: auto; height: auto">
                            <asp:Button ID="Subir0" runat="server" Text="CONSULTAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Subir0_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="height: 26px; text-align: center; width: auto;">
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="cod_paquete" EnableModelValidation="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:CommandField SelectImageUrl="~/Empleado/Director/images/demo/Select-icon.png" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="height: 2px"></td>
        </tr>
        <tr>
            <td class="right" style="text-align: right;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Contratar" runat="server" Text="Eliminar Datos Temporales" Font-Size="Small" Height="37px" Width="209px" OnClick="Contratar_Click"/>
                <br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Empleado/Bodega/PaquetePerdido.aspx">&lt;&lt; Regargar &gt;&gt;</asp:HyperLink>
            </td>
        </tr>
        </table>
</asp:Content>

