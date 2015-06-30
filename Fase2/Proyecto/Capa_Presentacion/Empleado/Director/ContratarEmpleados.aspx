<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="ContratarEmpleados.aspx.cs" Inherits="Empleado_Director_ContratarEmpleados" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 341px; border: 1px solid #cccccc" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700" Text="CONTRATACION DE EMPLEADO"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 26px">
                <asp:Label ID="Label28" runat="server" style="font-size: small" Text="Introduzca la siguiente información para crear la nueva cuenta del empleado."></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 26px">
                <asp:Label ID="Label29" runat="server" Font-Size="X-Small" ForeColor="#CC0000" style="font-size: x-small" Text="* Campos Requeridos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px">
                <asp:Label ID="Label31" runat="server" Text="Codigo de Usuario:"></asp:Label>
                <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;
                <asp:TextBox ID="txtcodigousuario" runat="server" Height="18px" Width="294px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px" class="center">
            &nbsp;
                <asp:Label ID="Label32" runat="server" Text="Usuarios ya Existentes:" style="font-size: x-small"></asp:Label>
                &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cod_usuario" DataValueField="cod_usuario">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Usuario]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px; text-align: left;" class="center">
                <asp:Label ID="Label34" runat="server" Text="Codigo de Empleado:"></asp:Label>
                <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                &nbsp;<asp:TextBox ID="txtcodigoempleado" runat="server" Height="18px" Width="283px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 2px" class="center">
                <asp:Label ID="Label36" runat="server" Text="Empleados ya Existentes:" style="font-size: x-small"></asp:Label>
                &nbsp;<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="cod_empleado" DataValueField="cod_empleado">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Empleado]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtnombre" runat="server" Height="21px" Width="451px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Apellido:"></asp:Label>
                &nbsp;<asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtapellido" runat="server" Height="21px" Width="450px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Direccion:"></asp:Label>
                &nbsp;<asp:Label ID="Label25" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtdireccion" runat="server" Height="21px" Width="451px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label10" runat="server" Text="Telefono:"></asp:Label>
                &nbsp;<asp:Label ID="Label24" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txttelefono" runat="server" Height="21px" Width="270px" MaxLength="8"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label14" runat="server" Text="Sueldo:"></asp:Label>
                &nbsp;<asp:Label ID="Label23" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
                <br />
                <asp:TextBox ID="txtsueldo" runat="server" Height="21px" Width="268px" MaxLength="9"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 13px">
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: left; width: 358px;">
                &nbsp;</td>
            <td>
                <asp:Button ID="Contratar" runat="server" Text="Contratar" Font-Size="Small" Height="37px" Width="95px" OnClick="Contratar_Click" />
            </td>
        </tr>
        <tr>
            <td class="right" style="text-align: left; " colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="right" style="text-align: left; " colspan="2">
    <table style="width: auto; border: 1px solid #cccccc; text-align: center;" align="center">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label37" runat="server" style="font-size: large; font-weight: 700; " Text="CARGAR ARCHIVO CSV - EMPLEADOS"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label38" runat="server" Text="Para cargar un nuevo empleado, debes de cargar primero sus datos de usuario y luego ingresar los datos de empleado."></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:Label ID="Label39" runat="server" style="text-align: left; font-weight: 700" Text="Agregar Usuario:"></asp:Label>
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
                <asp:Label ID="Label40" runat="server" style="text-align: left; font-weight: 700" Text="Agregar Empleado:"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 420px">
                <asp:FileUpload ID="FileUpload2" runat="server" Width="360px" />
            </td>
            <td>
                <asp:Button ID="Cargar" runat="server" Text="CARGAR" Font-Size="Small" Height="37px" Width="95px" OnClick="Cargar_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 420px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        </table>
            </td>
        </tr>
        </table>
</asp:Content>

