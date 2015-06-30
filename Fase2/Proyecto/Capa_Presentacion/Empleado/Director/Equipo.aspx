<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado/Director/MasterPage.master" AutoEventWireup="true" CodeFile="Equipo.aspx.cs" Inherits="Empleado_Director_Equipo" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div style="margin-left: auto; margin-right: auto; width: 600px;">
        <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700; text-align: center;" Text="EQUIPO DE TRABAJO"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="Usuario_cod_usuario" EnableModelValidation="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:CommandField SelectImageUrl="~/Empleado/Director/images/demo/Select-icon.png" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>


