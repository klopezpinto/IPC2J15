<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Servicio al Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="Casilla.aspx.cs" Inherits="Empleado_Servicio_al_Cliente_Casilla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 300px; text-align: center;">
                <asp:Label ID="Label30" runat="server" style="font-size: large; font-weight: 700; text-align: center;" Text="AUTORIZAR CASILLA"></asp:Label>
            <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="dpi" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:CommandField ShowEditButton="True" EditImageUrl="~/Empleado/Servicio al Cliente/images/demo/edit-validated-icon.png" />
                <asp:BoundField DataField="Usuario_cod_usuario" HeaderText="Codigo de Usuario" SortExpression="Usuario_cod_usuario" ReadOnly="True" />
                <asp:BoundField DataField="dpi" HeaderText="DPI" ReadOnly="True" SortExpression="dpi" />
                <asp:BoundField DataField="casilla" HeaderText="Casilla" SortExpression="casilla" />
            </Columns>
            <HeaderStyle Font-Bold="True" />
        </asp:GridView>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" SelectCommand="SELECT [dpi], [casilla], [Usuario_cod_usuario] FROM [Cliente]" UpdateCommand="UPDATE [Cliente] SET [casilla] = @casilla" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>"></asp:SqlDataSource>
</asp:Content>

