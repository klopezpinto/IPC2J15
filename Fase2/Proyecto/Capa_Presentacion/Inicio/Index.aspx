<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Inicio_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="wrapper col2">
        <div id="featured_slide">
            <div id="featured_content">
                <ul>
                    <li>
                        <img src="images/demo/videogame.png" alt="" />
                        <div class="floater">
                            <h2>Adquiere tus videojuegos antes que todos..</h2>
                        </div>
            </li>
                    <li>
                        <img src="images/demo/dron.jpg" alt="" />
                        <div class="floater">
                            <h2>Los GADGETS más geniales!</h2>
                        </div>
                    </li>
            <li>
                <img src="images/demo/tecno.jpg" alt="" />
                <div class="floater">
                    <h2>Los mejores precios en TECNOLOGIA..</h2>
                </div>
            </li>
            <li>
                <img src="images/demo/musica.jpg" alt="" />
                <div class="floater">
                    <h2>Lo mas actual en MUSICA!!</h2>
                </div>
            </li>
            </ul>
        </div>
        <a href="javascript:void(0);" id="featured-item-prev">
            <img src="layout/images/prev.png" alt="" /></a> <a href="javascript:void(0);" id="featured-item-next">
                <img src="layout/images/next.png" alt="" /></a>
    </div>
    </div>
</asp:Content>

