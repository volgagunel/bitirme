<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="urungoster.aspx.cs" Inherits="Oyun.urungoster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>

        </HeaderTemplate>
        <ItemTemplate>
            <div style="height: 300px; width:600px; border-style: solid; border-width: 1px;">
            <div style="height: 300px; width:200px; border-style: solid; border-width: 1px; float:left;">
            <img src='../<%#Eval("ImagePath") %>' height="300" width="200" />
            </div>
            <div style="height: 300px; width:395px; border-style: solid; border-width: 1px; float:left;">
                Oyun Adı: <%#Eval("Name") %> <br />
                Çıkış Yılı:<%#Eval ("Year") %> <br />
                Kategori:<%#Eval ("SubCategoryName") %> <br />
                Ücreti:₺<%#Eval ("Price") %> <br />
                </div>
                </div>
        </ItemTemplate>
        <FooterTemplate>

        </FooterTemplate>
    </asp:Repeater>
    <br />
    <asp:Button ID="b1" runat="server" Text="Sepete Ekle" OnClick="b1_Click" />


</asp:Content>
