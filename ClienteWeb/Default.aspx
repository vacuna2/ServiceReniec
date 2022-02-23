<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClienteWeb._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head>
        <title>

        </title>
        <style>
            * {
    padding: 0;
    margin: 0;
}

body {
    font: 11px Tahoma;
}

h1 {
    font: bold 32px Times;
    color: #666;
    text-align: center;
    padding: 20px 0;
}
.btnBuscar{
    background:#eee;
    height:25px;
    width:100px;
}
.btnBuscar:hover{
    background:#333;
    height:30px;
    width:110px;
    color :#ffffff;
}

#container {
    width: 700px;
    margin: 10px auto;
}

.mGrid {
    width: 100%;
    background-color: #fff;
    margin: 5px 0 10px 0;
    border: solid 1px #525252;
    border-collapse: collapse;
}

    .mGrid td {
        padding: 2px;
        border: solid 1px #c1c1c1;
        color: #717171;
    }

    .mGrid th {
        padding: 4px 2px;
        color: #fff;
        background: #424242 url(grd_head.png) repeat-x top;
        border-left: solid 1px #525252;
        font-size: 0.9em;
    }

    .mGrid .alt {
        background: #fcfcfc url(grd_alt.png) repeat-x top;
    }

    .mGrid .pgr {
        background: #424242 url(grd_pgr.png) repeat-x top;
    }

        .mGrid .pgr table {
            margin: 5px 0;
        }

        .mGrid .pgr td {
            border-width: 0;
            padding: 0 6px;
            border-left: solid 1px #666;
            font-weight: bold;
            color: #fff;
            line-height: 12px;
        }

        .mGrid .pgr a {
            color: #666;
            text-decoration: none;
        }

            .mGrid .pgr a:hover {
                color: #000;
                text-decoration: none;
            }
        </style>
    </head>
    <body>
    <h3>Buscar ciudadano por DNI</h3>
    <p>Ingrese DNI: <asp:TextBox runat="server" ID="txtDNI" /></p>
    <p>
        <asp:Button Text="Buscar Ciudadano" runat="server" ID="btnBuscar"  CssClass="btnBuscar" OnClick="btnBuscar_Click"/>
    </p>
    <p>
        <asp:GridView runat="server" ID="gvCiudadanos" CssClass="mGrid"></asp:GridView>
    </p>
    </body>
    </html>


</asp:Content>
