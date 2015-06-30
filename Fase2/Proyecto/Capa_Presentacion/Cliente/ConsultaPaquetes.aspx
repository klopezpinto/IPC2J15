<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultaPaquetes.aspx.cs" Inherits="Cliente_ConsultaPaquetes
    " %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin-left: auto; margin-right: auto; width: 350px;">
        <asp:Label ID="Label30" runat="server" Style="font-size: large; font-weight: 700" Text="PAQUETES"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="cod_paquete" EnableModelValidation="True" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:CommandField SelectImageUrl="~/Cliente/images/demo/Select-icon.png" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
    <asp:Label ID="Label33" runat="server" Style="text-align: right" Text="Usuario:"></asp:Label>
    &nbsp;<asp:Label ID="Label32" runat="server" Style="text-align: right" Text="Label"></asp:Label>
</asp:Content>


