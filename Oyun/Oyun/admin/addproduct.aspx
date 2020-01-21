<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addproduct.aspx.cs" Inherits="Oyun.admin.addproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">






</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h3>Ürün Ekleme Sayfası</h3>
<table>
    <tr>
        <td>Ürün Adı</td>
        <td><asp:TextBox ID="t1" CssClass="textbox" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Ne oyunu</td>
        <td><asp:TextBox ID="t2" CssClass="textbox" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Yıl</td>
        <td><asp:TextBox ID="t3" CssClass="textbox" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Ürün Fiyatı</td>
        <td><asp:TextBox ID="t4" CssClass="textbox" runat="server"></asp:TextBox> </td>
    </tr>
        <tr>
        <td>Kategori Adı</td>
        <td><asp:TextBox ID="t5" CssClass="textbox" runat="server"></asp:TextBox> </td>
    </tr>
    <tr>
        <td>Ürün Resmi</td>
        <td><asp:FileUpload ID="f1" runat="server"></asp:FileUpload> </td>
    </tr>

    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="b1" CssClass="btnKayit" runat="server" Text="Yükle" OnClick="b1_Click"/>
        </td>
    </tr>










</table>

</asp:Content>
